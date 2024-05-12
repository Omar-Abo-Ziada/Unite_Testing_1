using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLib_Test2
{
    public class CarStoreTest
    {
        public void Ctor_NewListOfCar()
        {
            // Arrange
            CarStore carStore = new CarStore();

            // Act
            List<Car> cars = carStore.cars;

            // Asert
            Assert.NotNull(cars);
            Assert.IsAssignableFrom<Car>(cars[0]);
        }

        public void AddCar()
        {
            // Arrange
            CarStore carStore = new CarStore();
            BMW BMWCar = new BMW();
            Toyota toyotaCar = new Toyota();

            // Act
            carStore.cars.Add(BMWCar);
            carStore.cars.Add(toyotaCar);

            int count = carStore.cars.Count;

            // Assert
            Assert.NotNull(carStore.cars);
            Assert.IsAssignableFrom<Car>(carStore.cars[0]);
            Assert.IsAssignableFrom<Car>(carStore.cars[1]);

            Assert.Equal(1, count);
        }

        public void AddCars()
        {
            // Arrange
            CarStore carStore = new CarStore();

            List<Car> cars = new List<Car>()
            {
                new BMW() , new Toyota()
            };

            // Act
           carStore.AddCars(cars);

            int count = carStore.cars.Count;

            // Assert
            Assert.NotNull(carStore.cars);
            Assert.IsAssignableFrom<Car>(carStore.cars[0]);
            Assert.IsAssignableFrom<Car>(carStore.cars[1]);

            Assert.Equal(1, count);
        }
    }
}

/*
   public class CarStore
    {
        public List<Car> cars;

        public CarStore()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void AddCars(List<Car> carsGroup)
        {
            cars.AddRange(carsGroup);
        }
    }
 */