using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_3
{
    class Book
    {
        private string _name;
        public string Name 
        {
            set
            {
                if (value.Length > 3)
                {
                    _name = value;

                }
                else
                {
                    return;
                }
            }
            get
            {
                return _name;
            } 
        }
        private int _pageCount;
        public int PageCount 
        {
            set
            {
                if (value > 10)
                {
                    _pageCount = value;
                }
                else
                {
                    return;
                }
            }
            get
            {
                return _pageCount;
            } 
        }

        public Book(string name, int pagecount)
        {
            Name = name;
            PageCount = pagecount;
        }
    }
}
