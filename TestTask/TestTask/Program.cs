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

            //Guid guid = new Guid();
            //bool isDone = false;
            //List<Guid> list = new List<Guid>();
            //string template = "00000000";

            //while (list.Count < 100)
            //{
            //    guid = Guid.NewGuid();
            //    string s = guid.ToString().Replace("-", "");


            //    //if (s.Contains(template))
            //    {
            //        list.Add(guid);
            //        Console.WriteLine(s);
            //    }
            //    if (list.Count == n) break;
            //}

            //for (int i = 0; i < 1000; i++)
            //{
            //    guid = Guid.NewGuid();
            //    string s = guid.ToString();
            //    Console.WriteLine(s);
            //}

            Guid guid = new Guid("68306412-f248-4dfa-96c0-d3123456cb75");

            byte digit = 0;
            int requiredNumberOfZeroes = 31;
            int actualNumberOfZeroes = 0;

            byte[] bytes = guid.ToByteArray();
            for (int i = 0; i < bytes.Length; i++)
            {
                if (actualNumberOfZeroes + 32 < requiredNumberOfZeroes + i)
                {
                    break;
                }

                uint temp = bytes[i];

                if (temp >> 4 == 0)
                {
                    ++actualNumberOfZeroes;
                    if (actualNumberOfZeroes == requiredNumberOfZeroes)
                    {
                        break;
                    }
                }
                else
                {
                    actualNumberOfZeroes = 0;
                }

                if (temp << 28 == 0)
                {
                    ++actualNumberOfZeroes;
                    if (actualNumberOfZeroes == requiredNumberOfZeroes)
                    {
                        break;
                    }
                }
                else
                {
                    actualNumberOfZeroes = 0;
                }
            }


            //Console.WriteLine(guid);
            //Console.ReadLine();
        }

        public static byte[] ToByteArray(Guid guid)
        {
            byte[] guidData = guid.ToByteArray();

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(guidData, 0, 4);
                Array.Reverse(guidData, 4, 2);
                Array.Reverse(guidData, 6, 2);
            }

            return guidData;
        }


    }
}
