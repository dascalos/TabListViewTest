using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

			var contPres = FindVisualChild<ContentPresenter>(BeerTabControl);

			if (contPres == null) return;

			var dataTemplate = contPres.ContentTemplate;
			if (dataTemplate == null) return;

			var lsv = (ListView)dataTemplate.FindName("BeerDetailsListView", contPres);
			if (lsv.Items == null || lsv.Items.Count <= 0) return;

			foreach (var ls in lsv.Items)
			{
				var beerCharacteristic = ls as BeerCharacteristic;

				if (beerCharacteristic != null && beerCharacteristic.BeerCharacteristicId.Equals(tagToFind))
				{
					//var mcp = FindVisualChild<ContentPresenter>(ls);
				}
			}
		}

		private static TChildItem FindVisualChild<TChildItem>(DependencyObject obj)
			where TChildItem : DependencyObject
		{
			for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
			{
				var child = VisualTreeHelper.GetChild(obj, i);
				if (child is TChildItem)
					return (TChildItem)child;
				else
				{
					var childOfChild = FindVisualChild<TChildItem>(child);
					if (childOfChild != null)
						return childOfChild;
				}
			}
			return null;
		}
	}
}
