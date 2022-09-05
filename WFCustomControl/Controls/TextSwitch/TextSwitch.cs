using System.Windows;
using System.Windows.Controls;

namespace WFCustomControl
{
	/// <summary>
	/// 显示On/OFF文本的开关按钮
	/// </summary>
	public class TextSwitch : CheckBox
	{
		static TextSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextSwitch), new FrameworkPropertyMetadata(typeof(TextSwitch)));
			ContentProperty.OverrideMetadata(typeof(TextSwitch), new FrameworkPropertyMetadata(string.Empty));
		}
    }
}
