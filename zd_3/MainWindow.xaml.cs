using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using классы;

namespace zd_3
{
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void Update ()  // Обновление списка
        {
            Grid.Items.Clear();
            foreach (var item in Roads.roads)
            {
                Grid.Items.Add(item);
            }
        }


        private void Add_Click(object sender, RoutedEventArgs e)  // Добавление объекта в лист
        {
            if (!string.IsNullOrWhiteSpace(Name_text.Text))
            {
                if (int.TryParse(Number_text.Text, out int number))
                {
                    if (number > 0)
                    {
                        if (double.TryParse(Width_text.Text, out double width))
                        {
                            if (width > 0)
                            {
                                if (double.TryParse(Lenght_text.Text, out double lenght))
                                {
                                    if (lenght > 0)
                                    {
                                        if (double.TryParse(Weight_text.Text, out double weight))
                                        {
                                            if (weight > 0)
                                            {
                                                if (int.TryParse(P_text.Text, out int p))
                                                {
                                                    if (!string.IsNullOrEmpty(Direction_text.Text))
                                                    {
                                                        var count = from _road in Roads.roads where _road.Name.ToLower() == Name_text.Text.ToLower() select _road;
                                                        if (count.Count() == 0)
                                                        {
                                                            Roads.Add_road(p, Direction_text.Text, width, lenght, weight, Name_text.Text, number);
                                                            Update();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Delete_index_Click(object sender, RoutedEventArgs e)  // Удаление объекта по индексу
        {
            if (int.TryParse(Index_text.Text, out int index))
            {
                if (index - 1 > 0 && index - 1 < Roads.roads.Count)
                {
                    Roads.Delete_road(index - 1);
                    Update();
                }   
                else
                {
                    MessageBox.Show("Индекс выходит за рамки списка");
                }    
            }
            else
            {
                MessageBox.Show("Индекс должен быть целым числом");
            }
        }

        private void Delete_object_Click(object sender, RoutedEventArgs e)  // Удаление объекта по тому, какой выделен в списке
        {
            if (Grid.SelectedItem != null)
            {
                Roads.Delete_road((Roads)Grid.SelectedItem);
                Update();
            }
            else
            {
                MessageBox.Show("Выделите объект");
            }
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            if (Grid.SelectedItem != null)
            {
                Info_text.Text = ((Roads)Grid.SelectedItem).info();
            }
            else
            {
                MessageBox.Show("Выделите объект");
            }
        }
    }
}
