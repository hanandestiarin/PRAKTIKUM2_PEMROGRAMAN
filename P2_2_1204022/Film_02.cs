using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204022
{
    class Film_02 : Product_film
    {
        protected string duration;

        public Film_02(string title, string duration)
        {
            this.MyTitle = title;
            this.duration = duration;
            this.MyType = "Film";

            Console.WriteLine("Ini dari class Film");
        }

        public string Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }
    }
}
