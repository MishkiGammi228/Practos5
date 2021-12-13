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
using Visual;
using Практическая_5;

namespace Практическая_5
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		Pair firstpara;
		Pair secondpara;
		private void Info_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Выполнил студент группы ИСП-34 Медведев Дмитрий" +
				"\nСоздать класс Pair (пара чисел). Создать необходимые методы и свойства." +
				"\nОпределить метод сравнения пар: пара p1 больше пары р2, если (first.pl > first.р2)" +
				"или (first.pl = first.р2) и (second.pl > second.р2). Создать перегруженные методы" +
				"SetParams, для установки параметров объекта.", "Информация");
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

        private void Fill_Click(object sender, RoutedEventArgs e)
        {
			Random rnd = new Random();
			firstpara = new Pair()
			{
				zn1 = rnd.Next(1, 100),
				zn2 = rnd.Next(1, 100),
			};
			secondpara = new Pair()
			{
				zn1 = rnd.Next(1, 100),
				zn2 = rnd.Next(1, 100),
			};
			Pair1.ItemsSource = VisualArray.ToDataTable(firstpara.PairArray).DefaultView;
			Pair2.ItemsSource = VisualArray.ToDataTable(secondpara.PairArray).DefaultView;
			result1.Text = null;
			result2.Text = null;
			result3.Text = null;
		}

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
			bool a = firstpara.Compare1();
			if (a == true) result1.Text = "Значение 1 больше значения 2.";
			else result1.Text = "Значение 1 не больше значения 2";
			bool b = firstpara.Compare2();
			if (b == true) result2.Text = "Значение 1 равно значению 2";
			else result2.Text = "Значение 1 не равно значению 2";
			bool c = secondpara.Compare3();
			if (c==true) result3.Text = "Значение 1 больше значения 2.";
			else result3.Text = "Значение 1 не больше значения 2";
		}
    }
}
