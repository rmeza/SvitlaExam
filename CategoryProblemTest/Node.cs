
using CategoryProblemTest.Model;

namespace CategoryProblemTest
{
    /// <summary>
    /// It's represent the basic Node.
    /// </summary>
    public class Node
    {
        private int _key;
        private Category _category;

        /// <summary>
        /// Represent the value sof the Node.
        /// </summary>
        public int Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
            
        }

        /// <summary>
        /// Category property.
        /// </summary>
        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    
        /// <summary>
        /// Represent a Left Node.
        /// </summary>
        public Node Left { get; set; }

        /// <summary>
        /// Represent a Rigth Node.
        /// </summary>
        public Node Right { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key"></param>
       public Node (int key, Category category)
        {
           _key = key;
           _category = new Category(category); 
            Left = null;
            Right = null;
        }

        /// <summary>
        /// Retreive Values property as a String.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Key.ToString();
        }
    }
}
