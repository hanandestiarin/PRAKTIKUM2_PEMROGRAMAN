using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204022
{
    class Program
    {
        static void Main(string[] args)
        {
           // Product_film myProduct = new Product_film();

           // myProduct.MyType = "FILM";

            // Console.WriteLine(myProduct.MyType);

            Film_1 buatfilm = new Film_1("The Medium", "2021", "2");
            Film_02 buatfilm_2 = new Film_02("The Call", "1");

            Console.WriteLine("Film 1 dengan judul {0} tahun {1} dengan durasi {2} jam", buatfilm.MyType, buatfilm.MyTitle, buatfilm.PageCount);
            Console.WriteLine("Film 2 dengan judul {0} {1} tahun 2020 dengan durasi {2} jam", buatfilm_2.MyType, buatfilm_2.MyTitle, buatfilm_2.Duration);
        }
    }
}
