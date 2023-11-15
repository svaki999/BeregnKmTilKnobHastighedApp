using BeregnHastighedApp;
using NUnit.Framework;

namespace BeregnHastighedTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BeregnHastighedKnobTest()
        {
            // Arrange
            var beregnHastighed = new BeregnHastighed();
            double kmIAlt = 100; 

            // Act
            double result = beregnHastighed.BeregnHastighedKnob(kmIAlt);

            // Assert
            Assert.AreEqual(53.996, result, 0.001);
        }

        [Test]
        public void BeregnHastighedKmPerTimeTest()
        {
            // Arrange
            var beregnHastighed = new BeregnHastighed();
            double knob = 50;

            // Act
            double result = beregnHastighed.BeregnHastighedKmTime(knob);

            // Assert
            Assert.AreEqual(92.599, result, 0.001);
        }
    }
}

