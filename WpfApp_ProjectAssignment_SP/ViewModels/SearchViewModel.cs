using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp_ProjectAssignment_SP.Utilities;

namespace WpfApp_ProjectAssignment_SP.ViewModels
{
    public class SearchViewModel : INotifyPropertyChanged
    {
		private string _productcodename;

		public string ProductNameCode
		{
			get { return _productcodename; }
			set { _productcodename = value; OnPropertyChanged(nameof(ProductNameCode)); }
		}

		private string _brand;

		public string BrandId
		{
			get { return _brand; }
			set { _brand = value; OnPropertyChanged(nameof(BrandId)); }
		}

		private bool _isnewenabled;

		public bool IsNewEnabled
		{
			get { return _isnewenabled; }
			set { _isnewenabled = value; OnPropertyChanged(nameof(IsNewEnabled)); }
		}

		private bool _isoldenabled;

		public bool IsOldEnabled
		{
			get { return _isoldenabled; }
			set { _isoldenabled = value; OnPropertyChanged(nameof(IsOldEnabled)); }
		}

		private bool _isrefurbshed;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

        }
		

        public bool IsRefurbishedEnabled
		{
			get { return _isrefurbshed; }
			set { _isrefurbshed = value; OnPropertyChanged(nameof(IsRefurbishedEnabled)); }
		}

		public ObservableCollection<USP_SearchProductRecords_Result> productrecordlist { get; set; }

		public SearchViewModel()
		{
			//productrecordlist = new ObservableCollection<USP_SearchProductRecords_Result>();
			DataAccess dataAccess = new DataAccess();
			productrecordlist = new ObservableCollection<USP_SearchProductRecords_Result>(dataAccess.FetchData("","","","",""));
			SearchProducts = new RelayCommand(FetchDataWithArguments);
		}

		public void FetchDataWithArguments()
		{
			String productname = "";
            string productode = "";
			if (ProductNameCode.Length != 0)
			{
				productname = ProductNameCode;
				bool check = int.TryParse(productname, out int a);
				if (check == true)
				{
					productode = productname;
				}
				else
				{
					productname = ProductNameCode;
				}
			}
			string brandid = "";
			String Producttypeids = GetCategoryIdsString(IsNewEnabled, IsOldEnabled, IsRefurbishedEnabled);
			DataAccess dataAccess = new DataAccess();
			var filteredlist = dataAccess.FetchData(productname, productode, brandid, "",Producttypeids);
			productrecordlist = filteredlist;
		}

		public ICommand SearchProducts { get; set; }
		private string GetCategoryIdsString(bool isNewEnabled, bool isOldEnabled, bool isRefurbishedEnabled)
        {
			string str = "";
			if (isNewEnabled)
			{
				str = str + "1,";
			}
			if (isOldEnabled)
			{
				str = str + "2,";
			}
			if (isRefurbishedEnabled)
			{
				str = str + "3";
			}
			return str;
        }
    }
}
