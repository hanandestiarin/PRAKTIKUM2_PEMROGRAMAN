using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product_1204022 myProduct = new Product_1204022();

            //myProduct.MyType = "DVD";

            // Console.WriteLine(myProduct.MyType);

            Book_1204022 product1 = new Book_1204022("Book", "C# Object oriented Solution", "300");
            DVD_1204022 product2 = new DVD_1204022("Eternal Sunshine of the spottless mind", "145");

            Console.WriteLine("Product 1 is a {0} called \" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
