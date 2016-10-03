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

namespace CommandRoutingIntoItemTemplate
{
	/// <summary>
	/// Interaction logic for UserControlTest.xaml
	/// </summary>
	public partial class UserControlTest : UserControl
	{
		public UserControlTest()
		{
			InitializeComponent();
		}

		private void CommandTestCanExecuteUserControl(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void CommandTestExecuteUserControl(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("CommandTestExecute Called");
		}

		private void CommandTestCanExecuteTextBox(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
			e.ContinueRouting = true;
		}

		private void CommandTestExecuteTextBox(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("CommandTestExecute Called direct");
		}
	}
}
