using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int n = 1;

            Guid guid;
            bool isDone = false;
            List<Guid> list = new List<Guid>();
            string template = "00000000";

            while (list.Count < 100)
            {
                guid = Guid.NewGuid();
                string s = guid.ToString().Replace("-", "");


                //if (s.Contains(template))
                {
                    list.Add(guid);
                    Console.WriteLine(s);
                }
                if (list.Count == n) break;
            }

            //for (int i = 0; i < 1000; i++)
            //{
            //    guid = Guid.NewGuid();
            //    string s = guid.ToString();
            //    Console.WriteLine(s);
            //}


            //Console.WriteLine(guid);
            Console.ReadLine();
        }
    }
}
