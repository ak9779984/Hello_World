using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate obj = new SampleDelegate();
            SampleDelegate.MathOperations objAdd = null;

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int addResult = 0;
            int subResult = 0;
            for (int i = 0; i < list.Count; i++)
            {
                //a = obj.Add(a, list[i]);
                //a = objAdd(a, list[i]);
                //a = obj.GetAddorSubDelegate(true).Invoke(a, list[i]);

                objAdd = obj.GetAddorSubDelegate(true);
                objAdd += obj.GetAddorSubDelegate(false);

                addResult = objAdd.Invoke(1, 2);
            }

            //Console.WriteLine(a);
            Console.WriteLine("Add Result : " + addResult);
            //Console.WriteLine(a);
            Console.Read();
        }
    }
}
