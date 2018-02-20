
using CategoryProblemTest.Model;
using System;
using System.Collections.Generic;

namespace CategoryProblemTest
{
    internal class Program
    {

        private static int categoryId;
        private static int parent;
        private static string name;
        private static string keywords;
        private static List<Node> nodesList = new List<Node>();

        /// <summary>
        /// Initializing the first tree based on DataSet provided.
        /// Nodes are CategoryId representation.
        /// </summary>
        /// <returns>Root node</returns>
        private static Node GenerateTree()
        {

            //We will consider Zero as root.
            // its my solution in oder to figured out the problem, because its a way to Join tow tress that are represent on dataset.


            //           0
            //
            //      /        \ 
            //    100        200
            //    /  \       /
            //   101  102  201
            //   / \        /
            //  103  109  202

            //Setting up values and the tree structure, specifiying the position in the tree.            
            //According the DataSet. 

            Node root = new Node(0, new Category());
            root.Left = new Node(100, new Category(100, -1, "Business", "Money"));
            root.Left.Left = new Node(101, new Category(101, 100, "Accounting", "Taxes"));
            root.Left.Right = new Node(102, new Category(102, 100, "Taxation", string.Empty));
            root.Left.Left.Left = new Node(103, new Category(103, 101, "Corporate Tax", string.Empty));
            root.Left.Left.Right = new Node(109, new Category(109, 101, "Small business Tax", string.Empty));
            root.Right = new Node(200, new Category(200, -1, "Tutoring", "Teaching"));
            root.Right.Left = new Node(201, new Category(201, 200, "Computer", string.Empty));
            root.Right.Left.Left = new Node(202, new Category(202, 201, "Operating System", string.Empty));


            // Root node.
            return root;

        }

        private static void Main()
        {
            Node rootNode = GenerateTree();

            Console.WriteLine("1rst problem: Input a Category id");
            #region first question
            string key = Console.ReadLine();
            if (int.TryParse(key, out int value))
            {
                SearchByCategoryId(rootNode, value);
            }
            #endregion


            #region Nth level

            Console.WriteLine("2nd problem: Input a level");

            string level = Console.ReadLine();
            if (int.TryParse(level, out int nth))
            {
                GetNodesInLevel(rootNode, nth);

                foreach (var item in nodesList)
                {
                    Console.WriteLine("CatId: {0}, Name:{1} ", item.Key, item.Category.Name);
                }
            }


            #endregion
            Console.ReadLine();
        }

        /// <summary>
        /// Search by category Id over the Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="tarjet"></param>
        /// <returns></returns>
        private static bool SearchByCategoryId(Node root, int tarjet)
        {
            if (root == null)
                return false;

            if (root.Key == tarjet)
            {
                categoryId = root.Category.CategoryId;
                parent = root.Category.ParentCategoryId;
                name = root.Category.Name;
                keywords = root.Category.Keywords;
                return true;
            }

            //check bouth (left and right).
            if (SearchByCategoryId(root.Left, tarjet) || SearchByCategoryId(root.Right, tarjet))
            {
                if (root.Key != 0)// not consider Zero node.
                {
                    // Console.WriteLine("parent {0} ", root.Key);

                    if (string.IsNullOrEmpty(keywords) && !string.IsNullOrEmpty(root.Category.Keywords))
                    {
                        //set values for Keywords from Parent.
                        keywords = root.Category.Keywords;
                    }

                    return true;
                }
                Console.WriteLine("{0} {1} {2} {3}", categoryId, parent, name, keywords);

            }

            return false;
        }



        /// <summary>
        /// Give the Nodes at the indicated Level.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="level"></param>
        private static void GetNodesInLevel(Node root, int level)
        {
            if (root == null || level < 0)
                return;
            if (level == 0)
                nodesList.Add(root);
            if (root.Left != null)
                GetNodesInLevel(root.Left, level - 1);
            if (root.Right != null)
                GetNodesInLevel(root.Right, level - 1);
        }

    }

}