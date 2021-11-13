using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204022
{
    public class Product_film
    {
        private string myType;
        private string myTitle;
        

        public Product_film()
        {
        }

        public Product_film(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
            
        }

        public string MyType
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;
            }
        }


    }
}
