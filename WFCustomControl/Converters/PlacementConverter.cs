using System;
using System.Globalization;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace WFCustomControl
{
	public class PlacementConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			PlacementDirection placementDirection = (PlacementDirection)value;
			object placementMode = Enum.ToObject(typeof(PlacementMode), (int)placementDirection);
			return placementMode;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			PlacementMode placementMode = (PlacementMode)value;
			object placementDirection = Enum.ToObject(typeof(PlacementDirection), (int)placementMode);
			return placementDirection;
		}
	}
}
