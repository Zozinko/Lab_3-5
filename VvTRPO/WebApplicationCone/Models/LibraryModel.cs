namespace WebApplicationCone.Models
{
    public class LibraryModel
    {
        public double Volume { get; set; }
        public double Height { get; set; }
        public double SmallRadius { get; set; }
        public double BigRadius { get; set; }
        public LibraryModel(double height , double smallRadius, double bigRadius) 
        { 
            BigRadius = bigRadius;
            Height = height;
            SmallRadius = smallRadius;
            Volume = 0;
        }
    }
}
