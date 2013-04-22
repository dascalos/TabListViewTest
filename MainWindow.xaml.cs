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

		private void Selector_OnSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			Console.WriteLine("Tab Selection Changed {0}", e.AddedItems[0]);
		}
	}
}
