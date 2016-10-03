using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandRoutingIntoItemTemplate
{
	public static class Commands
	{
		public static RoutedUICommand CommandTest = new RoutedUICommand("Test", "CommandTest", typeof(Commands));
	}
}
