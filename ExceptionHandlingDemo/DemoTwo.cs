using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class DemoTwo
    {
        public void Divided()
        {
            int x = 0;
            try
            {
                int a = 100 / x;
                
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Ans" + ex);
            }
            
        }

    }

}
