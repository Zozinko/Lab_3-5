using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLib;

namespace WpfAppCone.ViewModel
{
    public  class LibraryViewModel
    {
       static public double CalcLibrary(double height, double smallRadius, double bigRadius)
        {
            return Library.TruncatedConeVolume(height, bigRadius, smallRadius);
        }
    }
}
