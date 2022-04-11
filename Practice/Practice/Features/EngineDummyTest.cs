using System;
using NUnit.Framework;
using Practice.Models.Dummy;

namespace Practice.Features
{
    public class EngineDummyTest
    {
        private ICar car;
        private const string CAR_NAME = "Feature";
        [SetUp]
        public void Setup()
        {
            this.car = new FutureCar(new EngineDummy(), CAR_NAME);
        }

        [Test]
        public void should_can_start_when_engin_not_ready()
        {
            var name= this.car.Start();
            Assert.AreEqual(CAR_NAME, name);
            
        }
    }
}
