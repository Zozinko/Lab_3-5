using static ProgramLib.Library;

namespace ProgramLib.Tests
{
    /// <summary>
    /// The following tests are testing a method 'TruncatedConeVolume'
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// This tests whether an exception is thrown if the height of the truncated cone is zero.
        /// </summary>
        [Test]
        public void TruncatedConeVolume_HeightZero_ThrowsException()
        {
            Assert.Throws<Exception>(() => TruncatedConeVolume(0, 2, 6));
        }

        /// <summary>
        ///  This tests whether an exception is thrown if the small radius of the truncated cone is zero. 
        /// </summary>
        [Test]
        public void TruncatedConeVolume_SmallRadiusZero_ThrowsException()
        {
            Assert.Throws<Exception>(() => TruncatedConeVolume(5, 0, 6));
        }

        /// <summary>
        /// This tests whether an exception is thrown if the big radius of the truncated cone is zero
        /// </summary>
        [Test]
        public void TruncatedConeVolume_BigRadiusZero_ThrowsException()
        {
            Assert.Throws<Exception>(() => TruncatedConeVolume(5, 2, 0));
        }

        /// <summary>
        /// This tests whether an exception is thrown if the height of the truncated cone is negative.
        /// </summary>
        [Test]
        public void TruncatedConeVolume_HeightNegative_ThrowsException()
        {
            Assert.Throws<Exception>(() => TruncatedConeVolume(-5, 2, 6));
        }

        /// <summary>
        /// This tests whether an exception is thrown if the small radius of the truncated cone is negative.
        /// </summary>
        [Test]
        public void TruncatedConeVolume_SmallRadiusNegative_ThrowsException()
        {
            Assert.Throws<Exception>(() => TruncatedConeVolume(5, -2, 6));
        }

        /// <summary>
        /// This tests whether an exception is thrown if the big radius of the truncated cone is negative.
        /// </summary>
        [Test]
        public void TruncatedConeVolume_BigRadiusNegative_ThrowsException()
        {
            Assert.Throws<Exception>(() => TruncatedConeVolume(5, 2, -6));
        }

        /// <summary>
        /// This tests whether the method returns the correct volume for valid input parameters.
        /// </summary>
        [Test]
        public void TruncatedConeVolume_ValidInput_ReturnsCorrectVolume()
        {
            double expectedVolume = 272.271;
            double volume = TruncatedConeVolume(5, 2, 6);

            Assert.That(volume, Is.EqualTo(expectedVolume).Within(0.001));
        }
    }
}