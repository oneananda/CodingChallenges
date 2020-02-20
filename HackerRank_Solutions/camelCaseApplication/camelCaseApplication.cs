using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camelCaseApplication
{
    class Program
    {
        // Complete the camelcase function below.
        static int camelcase(string s)
        {
            char[] charArr = s.ToCharArray();
            List<int> whereToSeperate = new List<int>();
            int charCounter = 0;
            foreach (char singleChar in charArr)
            {
                if (char.IsUpper(singleChar))
                    whereToSeperate.Add(charCounter);
                charCounter++;
            }
            return whereToSeperate.Count() + 1;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int result = camelcase(s);

            Console.WriteLine(result);
            Console.ReadLine();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
