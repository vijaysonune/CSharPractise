using System;
using System.Collections.Generic;
using System.Text;

namespace Deletegate_Core
{
    class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string Path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(Path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
