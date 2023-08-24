using System;

namespace Expno5
{
    internal class Program
    {
        public delegate void ColorDel();
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }

        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }

        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }

        public static ColorDel[] IdentifySignal()
        {
            ColorDel[] retval = new ColorDel[3];
            retval[0] = Yellow; 
            retval[1] = Green; 
            retval[2] = Red;
            return retval;
        }

        static void Main(string[] args)
        {   

            ColorDel[] retval = IdentifySignal();
            ShowColors(retval);
        }

        public static void ShowColors(ColorDel[] retval)
        {
            foreach (ColorDel color in retval) {
                color.Invoke();
            }
        }
    }
}
