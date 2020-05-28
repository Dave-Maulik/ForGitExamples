using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGitExamples
{
    class Program
    {
        public static double Divide(int i, int d)
        {
            try
            {
                return i / d;
            }
            catch (Exception e)
            {

                throw new DivideByZeroException(e.Message);
            }
           
        }
    }
}