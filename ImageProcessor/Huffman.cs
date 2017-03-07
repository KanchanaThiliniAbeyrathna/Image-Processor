using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
    class Huffman
    {
        private List<Node> nodes = new List<Node>();
        public Node Root { get; set; }
        public Dictionary<int, int> Frequencies = new Dictionary<int, int>();

        public void Build(int[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }

                Frequencies[source[i]]++;
            }

            foreach (KeyValuePair<int, int> symbol in Frequencies)
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            while (nodes.Count > 1)
            {
                List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    List<Node> taken = orderedNodes.Take(2).ToList<Node>();

                    // Create a parent node by combining the frequencies
                    Node parent = new Node()
                    {
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }

                this.Root = nodes.FirstOrDefault();

            }

        }

        public BitArray Encode(int[] source)
        {
            List<bool> encodedSource = new List<bool>();

            for (int i = 0; i < source.Length; i++)
            {
                List<bool> encodedSymbol = this.Root.Traverse(source[i], new List<bool>());
                encodedSource.AddRange(encodedSymbol);
            }

            BitArray bits = new BitArray(encodedSource.ToArray());

            return bits;
        }

        public List<int> Decode(BitArray bits)
        {
            Node current = this.Root;
            List<int> decoded = new List<int>();

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded.Add(current.Symbol);
                    current = this.Root;
                }
            }

            return decoded;
        }

        public bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }

        public int[] convertToInt(Bitmap bitmap)
        {
            ImageConverter converter = new ImageConverter();
            byte[] newBA = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

            int[] newIA = new int[newBA.Length];
            for (int i = 0; i < newBA.Length; i++)
            {
                //int value=BitConverter.ToInt32(newBA, i);
                newIA[i] = newBA[i];
                //Console.WriteLine(newBA[i]);
            }

            /*for (int i = 0; i < newIA.Length; i++)
            {
                Console.WriteLine("dd"+newIbitA[i]);
            }*/
            return newIA;
        }

        public byte[] convertToByte(List<int> integers)
        {
            List<byte> bytes = new List<byte>(integers.Count * sizeof(byte));
            return integers.SelectMany(BitConverter.GetBytes).ToArray();
        }

        public Bitmap ToImage(int[] decoded,int width,int height)
        {
            Bitmap temp = new Bitmap(width, height);
            int i = 0;
            for (int x = 0; x < temp.Width; x++)
            {
                for (int y = 0; y < temp.Height; y++)
                {
                    //Console.WriteLine(decoded[i]);
                    try
                    {
                        Color newColor = Color.FromArgb(decoded[i]);
                        temp.SetPixel(x, y, newColor);
                        i++;
                    }catch(IndexOutOfRangeException e)
                    {
                        break;
                    }
                    
                }
            }
            return temp;
        }
    }

    public class Node
    {
        public int Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Traverse(int symbol, List<bool> data)
        {
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Traverse(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
