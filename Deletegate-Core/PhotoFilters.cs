using System;
using System.Collections.Generic;
using System.Text;

namespace Deletegate_Core
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("applying Brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("applying Contrast");

        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("resized image");
        }
    }
}
