using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    public class Roads : Road
    {
        private double p;  // коэффициент прочности
        private string direction;  // Маршрут
        public static List<Roads> roads = new List<Roads>();  // Лист дорог

        public Roads(double p, string direction, double _width, double _lenght, double _weight, string _name, int _number) : base(_width, _lenght, _weight, _name, _number)
        {
            this.p = p;
            this.direction = direction;
        }

        public double P
        {
            get { return p; }
            set { p = value; }
        }

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public static void Add_road(Roads road)  // Добавление объекта в лист
        {
            roads.Add(road);
        }

        public static void Add_road(double p, string direction, double _width, double _lenght, double _weight, string _name, int _number)  // Перегрузка добавления объекта в лист
        {
            var count = from _road in roads where _road.Name.ToLower() == _name.ToLower() select _road;
            if (count.Count() == 0)  // Проверка на совпадение по названию
            {
                Roads road = new Roads(p, direction, _width, _lenght, _weight, _name, _number);
                Add_road(road);
            }
        }

        public static void Delete_road(int n)  // Удаление объекта из листа (по индексу)
        {
            roads.RemoveAt(n);
        }

        public static void Delete_road(Roads road)  // Перегрузка удаления объекта из листа (по объекту)
        {
            roads.Remove(road);
        }

        override public double Q()  // Нахождение Q
        {
            if (p >= 5 && p <= 8)
            {
                return base.Q() * 1.1;
            }
            else if (p == 3 && p == 4 && p == 9 && p == 10)
            {
                return base.Q() * 1.6;
            }
            else
            {
                return base.Q() * 1.9;
            }
        }

        public override string info()
        {
            string text = base.info();
            text += $". \n{Direction}. \n{P} - коэффициент прочности. \nQ - {this.Q()}";
            return text;
        }
    }
}
