using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ProjectAssignment_SP.ViewModels
{
    public class Specification : BaseViewModel
    {

        public Specification(RelayCommand RemoveLastCommand)
        {
            this.RemoveLastCommand = RemoveLastCommand;
        }

        public RelayCommand RemoveLastCommand { get; set; }

        private int _specId;
        public int SpecId { get { return _specId; } set { _specId = value; OnPropertyChanged(nameof(SpecId)); } }


        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; OnPropertyChanged(nameof(Name));
            }
        }


        private string _value;
        public string Value { get { return _value; } set { _value = value; OnPropertyChanged(nameof(Value)); } }



    }

    public class Product : BaseViewModel
    {
        private string _productcode;

        public string ProductCode
        {
            get { return _productcode; }
            set { _productcode = value; OnPropertyChanged(nameof(ProductCode)); }
        }

        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; OnPropertyChanged(nameof(ProductName)); }
        }

        private int _brandid;

        public int BrandId
        {
            get { return _brandid; }
            set { _brandid = value; OnPropertyChanged(nameof(BrandId)); }
        }


        private string _categoryids;

        public string CategoryIds
        {
            get { return _categoryids; }
            set { _categoryids = value; OnPropertyChanged(nameof(CategoryIds)); }
        }

        private int _producttype;

        public int ProductType
        {
            get { return _producttype; }
            set { _producttype = value; OnPropertyChanged(nameof(ProductType)); }
        }


        private string _productdescription;

        public string ProductDescription
        {
            get { return _productdescription; }
            set { _productdescription = value; OnPropertyChanged(nameof(ProductDescription)); }
        }


        public ObservableCollection<Specification> SpecificationsList { get; set; }

    }

    public class InsertScreenViewModel : BaseViewModel
    {
        //public ObservableCollection<Product> ProductList { get; set; }

        //public Product Products { get; set;  }
        private string _productcode;

        public string ProductCode
        {
            get { return _productcode; }
            set { _productcode = value; OnPropertyChanged(nameof(ProductCode)); }
        }

        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; OnPropertyChanged(nameof(ProductName)); }
        }

        private int _brandid;

        public int BrandId
        {
            get { return _brandid; }
            set { _brandid = value; OnPropertyChanged(nameof(BrandId)); }
        }


        private string _categoryids;

        public string CategoryIds
        {
            get { return _categoryids; }
            set { _categoryids = value; OnPropertyChanged(nameof(CategoryIds)); }
        }

        private int _producttype;

        public int ProductType
        {
            get { return _producttype; }
            set { _producttype = value; OnPropertyChanged(nameof(ProductType)); }
        }


        private string _productdescription;

        public string ProductDescription
        {
            get { return _productdescription; }
            set { _productdescription = value; OnPropertyChanged(nameof(ProductDescription)); }
        }


        public ObservableCollection<Specification> SpecificationsList { get; set; }

    }
}
