using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGitExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double r = Program.Divide(x,y);
            Console.WriteLine(r);
            Console.Read();
        }

        public static double Divide(int i,int d)
        {
            try
            {
                return i / d;

            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
