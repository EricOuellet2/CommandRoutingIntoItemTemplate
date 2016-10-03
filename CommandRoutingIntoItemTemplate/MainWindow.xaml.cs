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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// ******************************************************************
		public MainWindow()
		{
			// Test pour ajouter bouton
			// Modif pour la prod
			InitializeComponent();
		}

		// ******************************************************************
		private void AddHack(object sender, RoutedEventArgs e)
		{
			this.ApplyToEachVisualChildRecursively(dp =>
			{
				var userControl = dp as UserControl;
				if (userControl != null)
				{
					CommandBindings.AddRange(userControl.CommandBindings);
				}
			});
		}

		// ******************************************************************

	}
}
