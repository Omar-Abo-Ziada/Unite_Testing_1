using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLib_Test2
{
    public class BMWTests
    {
        [Fact]
        public void IsStopped_velocity0_true()
        {
            // Arrange
            BMW BMWCar = new BMW();
            BMWCar.velocity = 0;

            // Act
            bool result = BMWCar.IsStopped();

            // Boolean Asserts
            Assert.True(result);
        }

        [Fact]
        public void IsStopped_velocity10_false()
        {
            // Arrange
            BMW BMWCar = new BMW();
            BMWCar.velocity = 10;

            // Act
            bool result = BMWCar.IsStopped();

            // Boolean Asserts
            Assert.False(result);
        }

        //************************************************

        [Fact]
        public void IncreaseVelocity_valocity10Add20_30()
        {
            // Arrange
            BMW BMWCar = new BMW();
            BMWCar.velocity = 10;
            double AddedVelocitoy = 20;

            // Act
            BMWCar.IncreaseVelocity(AddedVelocitoy);
            string result = BMWCar.GetDirection();

            // Equality Assert
            Assert.Equal(30, BMWCar.velocity);
            Assert.NotEqual(10, BMWCar.velocity);

            // Numeric Asserts
            Assert.False(BMWCar.velocity < 10);

            Assert.InRange(BMWCar.velocity, 20, 30);
            Assert.NotInRange(BMWCar.velocity, 10, 20);

            // string Asserts
            Assert.Equal(DrivingMode.Forward.ToString(), result);
        }


        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            BMW BMWCar = new BMW();
            BMWCar.drivingMode = DrivingMode.Forward;

            // Act
            string result = BMWCar.GetDirection();

            // string Asserts
            Assert.Equal(DrivingMode.Forward.ToString(), result);

            Assert.StartsWith("F", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("wa", result);
            Assert.DoesNotContain("zx", result);
        }


        [Fact]
        public void GetDirection_DirectionBackword_Backword()
        {
            // Arrange
            BMW BMWCar = new BMW();
            BMWCar.drivingMode = DrivingMode.Backward;

            // Act
            string result = BMWCar.GetDirection();

            // string Asserts
            Assert.Equal(DrivingMode.Backward.ToString(), result);

            Assert.StartsWith("B", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("Back", result);
            Assert.DoesNotContain("t", result);

        }

        //**********************************************

        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {
            // Arrange
            BMW BMWCar = new BMW();
            Toyota t2 = new Toyota();

            // Act
            Car car = BMWCar.GetMyCar();

            // Refrence Assert
            Assert.Same(BMWCar, car);
            Assert.NotSame(t2, car);
        }

        //**************************************************

        [Fact]
        public void Acceleration_Velocity_10_25()
        {
            // Arrange
            BMW BMWCar = new BMW();
            BMWCar.velocity = 10;

            // Act
            BMWCar.Accelerate();

            // Equality Assert
            Assert.Equal(25, BMWCar.velocity);
            Assert.NotEqual(10, BMWCar.velocity);

            // Numeric Asserts
            Assert.False(BMWCar.velocity < 10);

            Assert.InRange(BMWCar.velocity, 20, 30);
            Assert.NotInRange(BMWCar.velocity, 10, 20);
        }

    }
}
