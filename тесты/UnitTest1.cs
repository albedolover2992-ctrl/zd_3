using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using классы;

namespace тесты
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()  // Тест на метод Q в классе Road
        {
            double width = 20;  // Ширина дороги
            double lenght = 5;  // Длина дороги
            double weight = 1000;  // Масса дорожного покрытия
            string name = "name";  // Наименование дороги
            int number = 1;  // Число полос движения
            Road road = new Road(width, lenght, weight, name, number);
            double actialResult = road.Q();
            double expectedresult = 100;
            Assert.AreEqual(expectedresult, actialResult);
        }

        [TestMethod]
        public void TestMethod2()  // Тест на метод info в классе Road
        {
            double width = 20;  // Ширина дороги
            double lenght = 5;  // Длина дороги
            double weight = 1000;  // Масса дорожного покрытия
            string name = "name";  // Наименование дороги
            int number = 1;  // Число полос движения
            Road road = new Road(width, lenght, weight, name, number);  // Создание объекта

            string actialResult = road.info();
            string expectedresult = "name: 1 полос движения, \n20 м - ширина; \n5 м - длина; \n1000 кг - масса дорожного покрытия";
            Assert.AreEqual(expectedresult, actialResult);
        }

        [TestMethod]
        public void TestMethod3()  // Тест на метод Q в классе Roads
        {
            double width = 20;  // Ширина дороги
            double lenght = 5;  // Длина дороги
            double weight = 1000;  // Масса дорожного покрытия
            string name = "name";  // Наименование дороги
            int number = 1;  // Число полос движения
            double p = 1; // коэффициент прочности
            string diredirection = "Москва - Самара";  // Маршрут
            Roads road = new Roads(p, diredirection, width, lenght, weight, name, number);  // Создание объекта

            double actialResult = road.Q();
            double expectedresult = 190;
            Assert.AreEqual(expectedresult, actialResult);
        }

        [TestMethod]
        public void TestMethod4()  // Тест на метод info в классе Roads
        {
            double width = 20;  // Ширина дороги
            double lenght = 5;  // Длина дороги
            double weight = 1000;  // Масса дорожного покрытия
            string name = "name";  // Наименование дороги
            int number = 1;  // Число полос движения
            double p = 1; // коэффициент прочности
            string diredirection = "Москва - Самара";  // Маршрут
            Roads road = new Roads(p, diredirection, width, lenght, weight, name, number);  // Создание объекта

            string actialResult = road.info();
            string expectedresult = "name: 1 полос движения, \n20 м - ширина; \n5 м - длина; \n1000 кг - масса дорожного покрытия. \nМосква - Самара. \n1 - коэффициент прочности. \nQ - 190";
            Assert.AreEqual(expectedresult, actialResult);
        }
    }
}
