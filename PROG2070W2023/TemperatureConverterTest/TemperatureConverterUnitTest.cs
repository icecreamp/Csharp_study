using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG2070W2023;

namespace TemperatureConverterTest
{
    public class TemperatureConverterUnitTest
    {
        [TestFixture]

        public class test
        {
            // lower boundary
            // outputTemp = "There is a high degree of heat outside"
            // ambientTemp >= 36.0f && ambientTemp <= 40.0f

            [Test]

            public void TemperatureConverter_input36_outcomeThereisahighdegreeofheatoutside()
            {
                // Arrange
                float input = 36;
                string expected = "There is a high degree of heat outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }


            [Test]

            public void TemperatureConverter_input38point3_outcomeThereisahighdegreeofheatoutside()
            {
                // Arrange
                float input = 38.3f;
                string expected = "There is a high degree of heat outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }


            [Test]

            public void TemperatureConverter_input40_outcomeThereisahighdegreeofheatoutside()
            {
                // Arrange
                float input = 40;
                string expected = "There is a high degree of heat outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // ambientTemp >= 26.0f && ambientTemp <= 35.9f
            // outputTemp = "It is quite hot outside"

            [Test]

            public void TemperatureConverter_input26_outcomeItisquitehotoutside()
            {
                // Arrange
                int input = 26;
                string expected = "It is quite hot outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void TemperatureConverter_input35_outcomeItisquitehotoutside()
            {
                // Arrange
                int input = 35;
                string expected = "It is quite hot outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void TemperatureConverter_input28_outcomeItisquitehotoutside()
            {
                // Arrange
                int input = 28;
                string expected = "It is quite hot outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // ambientTemp >= 16.0f && ambientTemp <= 25.9f
            // outputTemp = "It is comfortable outside"

            [Test]
            public void TemperatureConverter_input17_outcomeItiscomfortableoutside()
            {
                // Arrange
                float input = 17;
                string expected = "It is comfortable outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void TemperatureConverter_input24_outcomeItiscomfortableoutside()
            {
                // Arrange
                float input = 24;
                string expected = "It is comfortable outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void TemperatureConverter_input22_outcomeItiscomfortableoutside()
            {
                // Arrange
                float input = 22;
                string expected = "It is comfortable outside";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }


            // ambientTemp >= 0.0f && ambientTemp <= 15.9f
            // outputTemp = "It is somewhat cold";

            [Test]
            public void TemperatureConverter_input3_outcomeItissomewhatcold()
            {
                // Arrange
                float input = 3;
                string expected = "It is somewhat cold";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void TemperatureConverter_input12_outcomeItissomewhatcold()
            {
                // Arrange
                float input = 12;
                string expected = "It is somewhat cold";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void TemperatureConverter_input10_outcomeItissomewhatcold()
            {
                // Arrange
                float input = 10;
                string expected = "It is somewhat cold";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // out of the boundary
            // outputTemp = "The temperature you is not within the acceptable range"

            [Test]

            public void TemperatureConverter_inputminus1_outcomeThetemperatureyouisnotwithintheacceptablerange()
            {
                // Arrange
                float input = -1;
                string expected = "The temperature you is not within the acceptable range";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void TemperatureConverter_input50_outcomeThetemperatureyouisnotwithintheacceptablerange()
            {
                // Arrange
                float input = 50;
                string expected = "The temperature you is not within the acceptable range";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void TemperatureConverter_inputminus25_outcomeThetemperatureyouisnotwithintheacceptablerange()
            {
                // Arrange
                float input = -25;
                string expected = "The temperature you is not within the acceptable range";

                // Act
                string actual = Temp.TemperatureConverter(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

        }
    }
}
