

namespace CategoryProblemTest.Model
{
    /// <summary>
    /// Category class to map the Dataset.
    /// </summary>
   public class Category
    {
        private int _categoryId;
        private int _parentCategoryId;
        private string _name;
        private string _keywords;

        /// <summary>
        /// Represent CategoryId.
        /// </summary>
        public int CategoryId
        {
            get
            {
                return _categoryId;
            }

            set
            {
                _categoryId = value;
            }

        }
        /// <summary>
        /// Represent ParentCategoryId
        /// </summary>
        public int ParentCategoryId
        {
            get
            {
                return _parentCategoryId;
            }

            set
            {
                _parentCategoryId = value;
            }

        }
        /// <summary>
        /// Represent Name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }
        /// <summary>
        /// Represent Keywords.
        /// </summary>
        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }

        }

        /// <summary>
        /// Cnstructor: Initializing values.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="parentCategoryId"></param>
        /// <param name="name"></param>
        /// <param name="keywords"></param>
        public Category(int categoryId, int parentCategoryId, string name, string keywords)
        {
            _categoryId = categoryId;
            _parentCategoryId = parentCategoryId;
            _name = name;
            _keywords = keywords;
        }
        /// <summary>
        /// Constructor empty.
        /// </summary>
        public Category()
        {

        }
        /// <summary>
        /// Constructor passing category parameter.
        /// </summary>
        /// <param name="category"></param>
        public Category(Category category)
        {
            _categoryId = category._categoryId;
            _parentCategoryId = category._parentCategoryId;
            _name = category._name;
            _keywords = category._keywords;
        }
    }
}
