using System;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor photo=new PhotoProcessor();
            PhotoFilter filetrs = new PhotoFilter();

            PhotoProcessor.PhotoFilterHandler filterHandler = filetrs.ApplyBrightness;
            Console.ReadLine();
        }
    }
}
