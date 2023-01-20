using System.Diagnostics.Metrics;
using System.Net.WebSockets;

namespace CodeWarsPlayground.CSharp.Kyu5
{
        public class PagnationHelper<T>
        {
        // TODO: Complete this class

        private int _itemsPerPage;
        private IList<T> _collection;
        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
            {
            _itemsPerPage= itemsPerPage;
            _collection = collection;
            }

            /// <summary>
            /// The number of items within the collection
            /// </summary>
            public int ItemCount
            {
                get
                {
                return _collection.Count();
                }
            }

            /// <summary>
            /// The number of pages
            /// </summary>
            public int PageCount
            {
                get
                {
                return (_collection.Count() / _itemsPerPage) +1;
                }
            }

            /// <summary>
            /// Returns the number of items in the page at the given page index 
            /// </summary>
            /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
            /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
            public int PageItemCount(int pageIndex)
            {
            if (pageIndex == -1 )
            {
                return -1;
            }
            if (pageIndex * _itemsPerPage > _collection.Count)
            {
                return -1;
            }

                return _collection.Skip(pageIndex*_itemsPerPage).Take(_itemsPerPage).Count();
            }

            /// <summary>
            /// Returns the page index of the page containing the item at the given item index.
            /// </summary>
            /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
            /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
            public int PageIndex(int itemIndex)
            {
            if (itemIndex == -1)
            {
                return -1;
            }
            if (itemIndex >= _collection.Count)
            {
                return -1;
            }
            return (itemIndex / _itemsPerPage); 
            }
        }
    }
