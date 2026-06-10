using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    public class Road
    {
        //
        private double width;  // Ширина дороги
        private double lenght;  // Длина дороги
        private double weight;  // Масса дорожного покрытия
        private string name;  // Наименование дороги
        private int number;  // Число полос движения
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Road(double _width, double _lenght, double _weight, string _name, int _number)  // Конструктор объекта
        {
            Width = _width;
            Lenght = _lenght;
            Weight = _weight;
            Name = _name;
            Number = _number;
        }

        virtual public double Q()  // Нахождение Q
        {
            return Width * Lenght * (Weight / 1000);
        }

        virtual public string info()  // Вывод информации об объекте
        {
            return $"{Name}: {number} полос движения, \n{Width} м - ширина; \n{Lenght} м - длина; \n{Weight} кг - масса дорожного покрытия";
        }
    }
}
