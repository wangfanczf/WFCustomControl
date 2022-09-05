using System.Windows;
using System.Windows.Controls;

namespace WFCustomControl
{
	/// <summary>
	/// 开关按钮
	/// </summary>
	public class Switch : CheckBox
	{
		static Switch()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
			ContentProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(string.Empty));
		}
	}
}
