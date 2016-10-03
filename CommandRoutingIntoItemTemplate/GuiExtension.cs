using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CommandRoutingIntoItemTemplate
{
	public static class GuiExtension
	{
		// ******************************************************************
		public static void ApplyToEachVisualChildRecursively(this DependencyObject obj, Action<DependencyObject> action)
		{
			if (obj != null && obj is Visual)
			{
				for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
				{
					DependencyObject child = VisualTreeHelper.GetChild(obj, i);
					if (child != null)
					{
						action(child);
						ApplyToEachVisualChildRecursively(child, action);
					}
				}
			}
		}

	}
}
