using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace karkowka_image
{
    internal class Image
    {
        public string source;
        public int views;
        public Image(string newSource)
        {
            source = newSource;
            views = 0;
        }
    }
}
