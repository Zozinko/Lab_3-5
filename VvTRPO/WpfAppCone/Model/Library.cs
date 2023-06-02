using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCone.Model
{
    public class Library
    {
        public double Volume { get; set; }
        public double Height { get; set; }
        public double SmallRadius { get; set; }
        public double BigRadius { get; set; }
        public Library(double height, double smallRadius, double bigRadius)
        {
            BigRadius = bigRadius;
            Height = height;
            SmallRadius = smallRadius;
            Volume = 0;
        }
    }
}
