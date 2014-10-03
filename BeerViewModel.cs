using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace TabListViewTest
{
	public class BeerViewModel : BaseViewModel
	{
		private ObservableCollection<BeerTabItem> _tabs;
		public ObservableCollection<BeerTabItem> Tabs
		{
			get { return _tabs; }
			set { _tabs = value; OnPropertyChanged("Tabs"); }
		}

		public List<BeerCharacteristic> ListOfBeerCharacteristics { get; set; }

		public BeerViewModel()
		{
			ListOfBeerCharacteristics = new List<BeerCharacteristic>
			{
				new BeerCharacteristic {Characteristic = "Hops", Level = "High", BeerTabName = "Founders KBS", BeerCharacteristicId = "E6B463DA-C2DF-471D-B9C8-320314739EDB"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Founders KBS", BeerCharacteristicId = "B13AD244-4CE1-48FD-8A3D-F9F7F9E5C984"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "Low", BeerTabName = "Founders KBS", BeerCharacteristicId = "A4C37A2E-8307-4305-B000-401B65DFDF26"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "High", BeerTabName = "Founders KBS", BeerCharacteristicId = "E3BCE222-D9A4-4F7C-B04A-002B00FBA37B"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Founders KBS", BeerCharacteristicId = "03A2DF99-4B85-4336-880C-B3023ED968F3"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "Low", BeerTabName = "Founders KBS", BeerCharacteristicId = "C4C1E676-07C8-4478-B20F-D7A4B8581C88"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "High", BeerTabName = "Founders KBS", BeerCharacteristicId = "94C3C6E4-C3FC-4AE6-A88F-8D634EAF9CAC"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Founders KBS", BeerCharacteristicId = "8076F5DD-5BB6-4A3E-821F-E2DBCAD70F75"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "Low", BeerTabName = "Founders KBS", BeerCharacteristicId = "59E7E01B-AE07-4713-931A-F247E28F0F9D"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "High", BeerTabName = "Founders KBS", BeerCharacteristicId = "4707788D-009D-409F-BA03-A70DE9363012"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Founders KBS", BeerCharacteristicId = "A1249244-24B4-4395-B92D-5CD342D9409F"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "Low", BeerTabName = "Founders KBS", BeerCharacteristicId = "FEBF2CC0-B490-48FC-9414-ED76978AB9CA"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "High", BeerTabName = "Founders KBS", BeerCharacteristicId = "2B866E5B-EFB6-4F5F-AD87-5A0C20B1A81C"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Founders KBS", BeerCharacteristicId = "18FEC2A3-B34C-47DD-80ED-FB428BA45678"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "Low", BeerTabName = "Founders KBS", BeerCharacteristicId = "D3713286-36ED-4E91-B494-E5194D6908F8"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "Low", BeerTabName = "Goose Island IPA", BeerCharacteristicId = "924EBC21-DA78-44B2-B710-0E511FDB9DBF"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Goose Island IPA", BeerCharacteristicId = "FA411D87-1956-4645-88DB-CB402BF94FCF"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "High", BeerTabName = "Goose Island IPA", BeerCharacteristicId = "7C64EA83-10E3-41BB-89D9-8AAEC84CC7C6"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "Medium", BeerTabName = "Leinenkugel Dark", BeerCharacteristicId = "2B172D9C-BCC4-466C-B25F-16816BBB12D9"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Low", BeerTabName = "Leinenkugel Dark", BeerCharacteristicId = "4C3E0F9D-97A6-48AB-96EE-E197130C1EEB"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "High", BeerTabName = "Leinenkugel Dark", BeerCharacteristicId = "D638999B-B4F8-445D-83DE-3156ECB5B648"},
				new BeerCharacteristic {Characteristic = "Hops", Level = "High", BeerTabName = "Magic Hat Vinyl", BeerCharacteristicId = "D239AB36-9973-4BBE-A5D0-F0470DA62E5D"},
				new BeerCharacteristic {Characteristic = "Barley", Level = "Medium", BeerTabName = "Magic Hat Vinyl", BeerCharacteristicId = "61BBCDD2-C5FF-4CBF-B455-B0AEF4208138"},
				new BeerCharacteristic {Characteristic = "Grain", Level = "Low", BeerTabName = "Magic Hat Vinyl", BeerCharacteristicId = "77AB2322-4206-412C-88F0-1D6E41203BBA"}
			};

			var tabs = ListOfBeerCharacteristics
				.GroupBy(z => z.BeerTabName)
				.Select(z => new BeerTabItem
				{
					TabHeader = z.Key,
					Bcs = z
				})
				.ToList();

			Tabs = new ObservableCollection<BeerTabItem>(tabs);
		}
	}

	public class BeerTabItem
	{
		public string TabHeader { get; set; }
		public IEnumerable<BeerCharacteristic> Bcs { get; set; }
	}

	public class BeerCharacteristic
	{
		public string Characteristic { get; set; }
		public string Level { get; set; }
		public string BeerTabName { get; set; }
		public string BeerCharacteristicId { get; set; }
	}

	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
