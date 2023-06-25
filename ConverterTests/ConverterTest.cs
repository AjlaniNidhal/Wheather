using Converter.ConverterProject;
using System;
using Xunit;

namespace Converter.ConverterTests
{
    public class ConverterTest : IDisposable
    {
        private ConverterService converterService = new ConverterService();
        //public ConverterTest()
        //{
                
        //}
        // [Fact]
        // public void ConvertCilciusToFeranhait_0_32()
        //{
        //    //Arrange
        //    var expected = 32;
        //    var converterService = new ConverterService();

        //    //Act
        //    var actual = converterService.GetFernhaitFromCelcius(0);

        //    //Assert
        //    Assert.Equal(actual, expected);

        //}

        //[Fact]
        //public void ConvertCilciusToFeranhait_2_1()
        //{
        //    //Arrange
        //    var expected = 1;
        //    var converterService = new ConverterService();

        //    //Act
        //    var actual = converterService.GetFernhaitFromCelcius(2);

        //    //Assert
        //    Assert.Equal(actual, expected);

        //}


        [Theory]
        [InlineData(0, 32)]
        [InlineData(-10, 14)]
        public void ConvertCilciusToFeranhait(double value, double expected)
        {
            //Arrange
            //ConverterService converterService = new ConverterService();

            //Act
            var actual = converterService.GetFernhaitFromCelcius(value);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(0, -17.8)]
        [InlineData(2, -16.7)]
        public void ConvertFeranhaitToCilcius(double value, double expected)
        {
            //Arrange
            //ConverterService converterService = new ConverterService();

            //Act
            var actual = converterService.GetCelciusFromFernhait(value);

            //Assert
            Assert.Equal(actual, expected, 1);

        }

        public void Dispose()
        {
            converterService.Dispose();
        }
    }
}
