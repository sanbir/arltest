using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 6;
            //int n = 1;

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

            //Guid guid = new Guid("68306412-f248-4dfa-96c0-d3123456cb75");

            //byte digit = 0;

            int requiredNumberOfZeroes = 6;

            //IsRequirementMet(guid, requiredNumberOfZeroes);


            var list = new List<Guid>
            {
                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
                                new Guid("00000012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-00fa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00000456cb75"),

                new Guid("00050012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306410-0000-1dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-00060456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d3123456cb75"),
                new Guid("68306416-0000-0dfa-96c0-d3123456cb75"),
                new Guid("68306412-f248-4dfa-96c0-04440456cb75"),

                new Guid("00006012-f248-4dfa-96c0-d31234000000"),
                new Guid("68306416-0000-0dfa-96c0-d0000006cb75"),
                new Guid("68300000-0248-4dfa-96c0-04440456cb75"),
            };

            Stopwatch sw=new Stopwatch();
            sw.Start();
            //////////////////////////
            foreach (var guid in list)
            {
                if (IsRequirementMet(guid, requiredNumberOfZeroes))
                {
                    //Console.WriteLine(guid);
                }
            }
            ///////////////////////////////////
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
            sw = new Stopwatch();
            sw.Start();

            var template = new String('0', 6);

            foreach (var guid in list)
            {
                if (IsRequirementMetStrings(guid, template))
                {
                    //Console.WriteLine(guid);
                }
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            //Console.WriteLine(guid);
            Console.ReadLine();
        }

        private static bool IsRequirementMet(Guid guid, int requiredNumberOfZeroes)
        {
            int actualNumberOfZeroes = 0;
            byte[] bytes = guid.ToByteArray();

            if (BitConverter.IsLittleEndian)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (actualNumberOfZeroes + 32 < requiredNumberOfZeroes + i)
                    {
                        return false;
                    }

                    uint temp;
                    switch (i)
                    {
                        case 0:
                            temp = bytes[3];
                            break;
                        case 1:
                            temp = bytes[2];
                            break;
                        case 2:
                            temp = bytes[1];
                            break;
                        case 3:
                            temp = bytes[0];
                            break;
                        case 4:
                            temp = bytes[5];
                            break;
                        case 5:
                            temp = bytes[4];
                            break;
                        case 6:
                            temp = bytes[7];
                            break;
                        case 7:
                            temp = bytes[6];
                            break;
                        default:
                            temp = bytes[i];
                            break;
                    }

                    if (temp >> 4 == 0)
                    {
                        ++actualNumberOfZeroes;
                        if (actualNumberOfZeroes == requiredNumberOfZeroes)
                        {
                            return true;
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
                            return true;
                        }
                    }
                    else
                    {
                        actualNumberOfZeroes = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (actualNumberOfZeroes + 32 < requiredNumberOfZeroes + i)
                    {
                        return false;
                    }

                    uint temp = bytes[i];

                    if (temp >> 4 == 0)
                    {
                        ++actualNumberOfZeroes;
                        if (actualNumberOfZeroes == requiredNumberOfZeroes)
                        {
                            return true;
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
                            return true;
                        }
                    }
                    else
                    {
                        actualNumberOfZeroes = 0;
                    }
                }
            }

            return false;
        }

        private static bool IsRequirementMetStrings(Guid guid, string template)
        {
            var guidString = guid.ToString("N");
            if (guidString.Contains(template)) return true;
            return false;
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
