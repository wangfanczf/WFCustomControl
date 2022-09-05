using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WFCustomControl
{
	public class TipTextBox : TextBox
	{
		[Category("TipTextBox")]
		public string TipText
		{
			get { return (string)GetValue(TipTextProperty); }
			set { SetValue(TipTextProperty, value); }
		}

		public static readonly DependencyProperty TipTextProperty =
			DependencyProperty.Register("TipText", typeof(string), typeof(TipTextBox), new PropertyMetadata("请输入..."));

		static TipTextBox()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TipTextBox), new FrameworkPropertyMetadata(typeof(TipTextBox)));
		}
	}
}
