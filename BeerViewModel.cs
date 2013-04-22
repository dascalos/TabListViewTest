using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TabListViewTest
{
	public class BeerViewModel : BaseViewModel
	{
		public BeerViewModel()
		{
			BeerList.Add(new Beer
				{
					BeerName = "Founders KBS",
					BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "High" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low"},
							new BeerCharacteristic { Characteristic = "Hops", Level = "High" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low"},
							new BeerCharacteristic { Characteristic = "Hops", Level = "High" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low"},
							new BeerCharacteristic { Characteristic = "Hops", Level = "High" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low"},
							new BeerCharacteristic { Characteristic = "Hops", Level = "High" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low"}
						}
				});
			BeerList.Add(new Beer
			{
				BeerName = "Goose Island IPA",
				BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "Low" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "High"}
						}
			});
			BeerList.Add(new Beer
			{
				BeerName = "Leinenkugel Dark",
				BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "Medium" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Low"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "High"}
						}
			});
			BeerList.Add(new Beer
			{
				BeerName = "Magic Hat Vinyl",
				BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "High" },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium"},
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low"}
						}
			});
		}

		private readonly ObservableCollection<Beer> _beerList = new ObservableCollection<Beer>();
		public ObservableCollection<Beer> BeerList
		{
			get { return _beerList; }
		}
	}

	public class Beer
	{
		public string BeerName { get; set; }
		public List<BeerCharacteristic> BeerCharacteristics { get; set; }
	}

	public class BeerCharacteristic
	{
		public string Characteristic { get; set; }
		public string Level { get; set; }
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
