using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeTest
{
    [TestClass]
    public class WeatherTest
    {
        [TestMethod]
       public void Test_of_WeatherNumber_Method()
        {
            Weather weather = new Weather();
            int number = 53;
            int expected=-2;

            //Arrange

            weather.FindTempScore(number);


            //Act



            Assert.AreEqual(expected, weather.TempScore);

            //Assert
        }

        [TestMethod]
        public void Test_Of_WeatherScore()
        {
            Weather weather = new Weather();
            int numb = 1;
            string name = "Sunny";


            weather.FindGameWeather(numb);


            Assert.AreEqual(name, weather.GameWeather);

        }
    }
}
