namespace ProgramLib
{
    public static class Library
    {
        /// <summary>
        /// Counts Truncated cone volume with given parameters.
        /// </summary>
        /// <param name="height">Truncated cone height</param>
        /// <param name="smallRadius">Truncated cone biggest radius</param>
        /// <param name="bigRadius">Truncated cone smallest radius</param>
        /// <returns>Truncated cone volume</returns>
        /// <exception cref="Exception">Throws an exception if any of the parameters is less than or equal to zero</exception>
        public static double TruncatedConeVolume(double height, double smallRadius, double bigRadius)
        {
            if (height <= 0 || smallRadius <= 0 || bigRadius <= 0)
                throw new Exception($"{nameof(height)}, {nameof(smallRadius)} and {nameof(bigRadius)} must be positive real numbers, greater than zero.");

            var result = 1d / 3d * Math.PI * height * (Math.Pow(smallRadius, 2) + smallRadius * bigRadius + Math.Pow(bigRadius, 2));
            return result;
        }
    }
}