using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sample : System.IDisposable

    {
        public Sample()
        {
            Console.WriteLine("Opened");
            
        }
        



        public void database()
        {
            Console.WriteLine("wirting into database");
        }

        public void Dispose()
        {
            Console.WriteLine("Closing database");
            
        }
    }
}
