using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>();
            shopping.Add("Carottes");
            shopping.Add("Oignons");
            shopping.Add("Patates");
            shopping.Add("Salade");
            shopping.Add("Tomates");

            foreach (string shop in shopping)
            {
                Console.WriteLine(shop);
            }
        }
        
    }
}
