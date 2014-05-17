using System;
using System.Windows;

namespace TabListViewTest
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new BeerViewModel();
		}

		private void BeerDetailsListView_OnLoaded(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("List View Loaded: {0}", sender);
		}
	}
}
