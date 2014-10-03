using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TabListViewTest
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new BeerViewModel();
		}

		private void FindByTagClick(object sender, RoutedEventArgs e)
		{
			const string tagToFind = "4C3E0F9D-97A6-48AB-96EE-E197130C1EEB";

			var vm = DataContext as BeerViewModel;

			if (vm == null) return;

			var tabName = vm.ListOfBeerCharacteristics.FirstOrDefault(z => z.BeerCharacteristicId.Equals(tagToFind));

			if (tabName == null) return;

			foreach (var btc in BeerTabControl.Items.Cast<object>().Where(itm => ((BeerTabItem)itm).TabHeader.Equals(tabName.BeerTabName)))
			{
				BeerTabControl.SelectedItem = btc;
				break;
			}

			//var contPres = VisualTreeHelperExtensions.FindVisualChild<ContentPresenter>(BeerTabControl);

			//if (contPres == null) return;

			//var dataTemplate = contPres.ContentTemplate;
			//if (dataTemplate == null) return;

			//var lsv = (ListView)dataTemplate.FindName("BeerDetailsListView", contPres);
			//if (lsv.Items == null || lsv.Items.Count <= 0) return;

		}
	}
}
