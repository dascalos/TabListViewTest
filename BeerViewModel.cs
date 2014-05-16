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
							new BeerCharacteristic { Characteristic = "Hops", Level = "High", TabOrder = 1 },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 2 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low", TabOrder = 3 },
							new BeerCharacteristic { Characteristic = "Hops", Level = "High", TabOrder = 4  },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 5 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low", TabOrder = 6 },
							new BeerCharacteristic { Characteristic = "Hops", Level = "High", TabOrder = 7  },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 8 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low", TabOrder = 9 },
							new BeerCharacteristic { Characteristic = "Hops", Level = "High", TabOrder = 10 },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 11 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low", TabOrder = 12 },
							new BeerCharacteristic { Characteristic = "Hops", Level = "High", TabOrder = 13  },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 14 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low", TabOrder = 15 }
						}
				});
			BeerList.Add(new Beer
			{
				BeerName = "Goose Island IPA",
				BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "Low", TabOrder = 16  },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 17 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "High", TabOrder = 18 }
						}
			});
			BeerList.Add(new Beer
			{
				BeerName = "Leinenkugel Dark",
				BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "Medium", TabOrder = 19  },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Low", TabOrder = 20 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "High", TabOrder = 21 }
						}
			});
			BeerList.Add(new Beer
			{
				BeerName = "Magic Hat Vinyl",
				BeerCharacteristics = new List<BeerCharacteristic>
						{
							new BeerCharacteristic { Characteristic = "Hops", Level = "High", TabOrder = 22  },
							new BeerCharacteristic { Characteristic = "Barley", Level = "Medium", TabOrder = 23 },
							new BeerCharacteristic { Characteristic = "Grain", Level = "Low", TabOrder = 24 }
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
		public int TabOrder { get; set; }
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
