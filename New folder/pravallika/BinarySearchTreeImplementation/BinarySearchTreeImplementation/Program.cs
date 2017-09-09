using System;
using System.Linq;
using System.Text;

namespace BinarySearchTreeImplementation
{
        class Node
        {
            public int item;
            public Node leftc;
            public Node rightc;
        }
        class Tree
        {
            public Node root;
            public int flag = 0;
            public int[] arr = new int[20];
            public Tree()
            {
                root = null;
            }
            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                Node newNode = new Node();
                newNode.item = id;
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.item)
                        {
                            current = current.leftc;
                            if (current == null)
                            {
                                parent.leftc = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.rightc;
                            if (current == null)
                            {
                                parent.rightc = newNode;
                                return;
                            }
                        }
                    }
                }
            }
            public void Inorder(Node Root)
            {
                if (Root != null)
                {
                    Inorder(Root.leftc);
                    Console.Write(Root.item + " ");
                    Inorder(Root.rightc);
                }
            }
            public void descendingOrder(Node Root)
            {
                if (Root != null)
                {
                    descendingOrder(Root.rightc);
                    Console.Write(Root.item + " ");
                    descendingOrder(Root.leftc);
                }
            }
            public Node search(Node Root, int id)
            {
                if (Root == null)
                {
                    return null;
                }
                if (Root.item == id)
                {
                    Console.WriteLine("Element Found");
                    flag = 1;
                    return Root;
                }
                else
                {
                    if (id < Root.item)
                    {
                        return search(Root.leftc, id);
                    }
                    else
                    {
                        return search(Root.rightc, id);
                    }
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Tree treeObj = new Tree();
                Console.WriteLine("Enter no.of nodes:");
                int numOfNodes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the nodes");
                for (int i = 0; i < numOfNodes; i++)
                {
                    int item = Convert.ToInt32(Console.ReadLine());
                    treeObj.Insert(item);
                }
                Console.WriteLine("Inorder Traversal : ");
                treeObj.Inorder(treeObj.ReturnRoot());
                Console.WriteLine("\nDisplaying elements in descending order:\n");
                treeObj.descendingOrder(treeObj.ReturnRoot());
                Console.WriteLine("\nEnter the element you want to search");
                int searchID = Convert.ToInt32(Console.ReadLine());
                treeObj.search(treeObj.ReturnRoot(), searchID);
                if (treeObj.flag != 1)
                {
                    Console.WriteLine("Element not Found");
                }
                Console.ReadKey();
            }
        }
    }

