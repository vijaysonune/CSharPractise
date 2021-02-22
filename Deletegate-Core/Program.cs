using System;

namespace Deletegate_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var filter = new PhotoFilters();
            var photoProcess = new PhotoProcessor();
            Action<Photo> photoFilterHandler = filter.ApplyBrightness;
            photoFilterHandler += filter.ApplyContrast;
            photoFilterHandler += RemoveRedEyes;
            photoProcess.Process(" image", photoFilterHandler);
            Console.ReadLine();
        }

        static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEyes");
        }
    }
}
