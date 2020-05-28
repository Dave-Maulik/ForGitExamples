using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
                if (d == 0)
                    throw new DivideByZeroException();
                else
                    return i / d;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            finally
            {
                Console.WriteLine("In Finally blocks");
            }
        }
    }
}
