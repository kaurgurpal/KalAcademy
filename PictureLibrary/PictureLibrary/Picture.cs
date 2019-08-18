using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureLibrary
{
   public class Picture
    {
        public string picName { get; set; }
        public string albumName { get; set; }
        public DateTime dateAdded { get; set; }
        public string path { get; set; }
    }
}
