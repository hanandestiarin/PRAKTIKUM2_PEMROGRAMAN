using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204022
{
   public class Film_1 : Product_film
    {
        protected string pageCount;

        public Film_1(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }
     
        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}
