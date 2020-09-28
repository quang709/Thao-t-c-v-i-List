using System;
using System.Collections.Generic;
using System.Linq;

namespace Thao_tác_với_List
{
    class Program
    {
            static void Main(string[] args)
        {
            List<string> Animal = new List<string>();
            Animal.Add("lion");
            Animal.Add("cat");
            Animal.Add("dog");
            Animal.Add("elephant");
            Console.WriteLine("Danh sach hien tai la : ");
            foreach (var item in Animal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Danh sach sau khi xoa la :");
            Animal.Remove("dog");
            foreach (var item in Animal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Danh sach sau khi sap xep :");
            var sapxep = from name in Animal
                         orderby name.Length
                         select name;
            foreach (var item in sapxep)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Index cua cat la :");
            Console.WriteLine(Animal.IndexOf("cat"));
        }
    }
}
    
