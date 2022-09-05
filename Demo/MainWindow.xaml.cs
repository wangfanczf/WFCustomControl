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

namespace Demo
{
	/// <summary>
	/// Bubble应用
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void buttonRight_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxRight.Text))
			{
				bubbleRight.Text = "右侧弹出信息";
				bubbleRight.IsOpen = true;
				return;
			}
		}

		private void buttonLeft_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxLeft.Text))
			{
				bubbleLeft.Text = "左侧弹出信息";
				bubbleLeft.IsOpen = true;
				return;
			}
		}

		private void buttonTop_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxTop.Text))
			{
				bubbleTop.Text = "上方弹出信息";
				bubbleTop.IsOpen = true;
				return;
			}
		}

		private void buttonBottom_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxBottom.Text))
			{
				bubbleBottom.Text = "下方弹出信息";
				bubbleBottom.IsOpen = true;
				return;
			}
		}

		private void LinkButton_Click(object sender, RoutedEventArgs e)
		{
			popupInput.IsOpen = true;
		}
	}
}
