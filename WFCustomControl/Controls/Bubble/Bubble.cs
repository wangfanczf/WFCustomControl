using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WFCustomControl
{
	public class Bubble : Control
	{
		public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register(
			"IsOpen", typeof(bool), typeof(Bubble), new FrameworkPropertyMetadata(false));

		[Category("Bubble")]
		public bool IsOpen
		{
			get
			{
				return (bool)GetValue(IsOpenProperty);
			}
			set
			{
				SetValue(IsOpenProperty, value);
			}
		}

		public static readonly DependencyProperty PlacementTargetProperty = DependencyProperty.Register(
			"PlacementTarget", typeof(UIElement), typeof(Bubble), new FrameworkPropertyMetadata(null));
		[Category("Bubble")]
		public UIElement PlacementTarget
		{
			get
			{
				return (UIElement)GetValue(PlacementTargetProperty);
			}
			set
			{
				SetValue(PlacementTargetProperty, value);
			}
		}
	
		public static readonly DependencyProperty PlacementProperty = DependencyProperty.Register(
			"Placement", typeof(PlacementDirection), typeof(Bubble), new FrameworkPropertyMetadata(PlacementDirection.Right));
		[Category("Bubble")]
		public PlacementDirection Placement
		{
			get
			{
				return (PlacementDirection)GetValue(PlacementProperty); 
			}
			set
			{
				SetValue(PlacementProperty, value);
			}
		}

		public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
			"Text", typeof(string), typeof(Bubble), new FrameworkPropertyMetadata("Bubble"));
		[Category("Bubble")]
		public string Text
		{
			get
			{
				return (string)GetValue(TextProperty);
			}
			set
			{
				SetValue(TextProperty, value);
			}
		}

		static Bubble()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Bubble), new FrameworkPropertyMetadata(typeof(Bubble)));
			
			// 设置气泡的默认颜色
			Color defaultColor = Color.FromRgb(222, 255, 235);
			SolidColorBrush solidColorBrush = new SolidColorBrush(defaultColor);
			BackgroundProperty.OverrideMetadata(typeof(Bubble), new FrameworkPropertyMetadata(solidColorBrush));
		}
	}
}
