using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>();
            liste.Add("ahmet");
            liste.Add("mehmet");
            Console.WriteLine("eklendi==>"+liste.Count);

            
            Console.ReadKey();
        }

        
    }
}
