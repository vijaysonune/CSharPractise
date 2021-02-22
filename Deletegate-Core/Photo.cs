using System;
using System.Collections.Generic;
using System.Text;

namespace Deletegate_Core
{
    class Photo
    {
        public static Photo Load(string Path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Photo saved successfully!");
        }
    }
}
