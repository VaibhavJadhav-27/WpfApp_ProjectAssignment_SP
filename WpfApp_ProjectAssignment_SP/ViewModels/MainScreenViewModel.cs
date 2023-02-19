using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ProjectAssignment_SP.ViewModels
{
    internal class MainScreenViewModel
    {
        public InsertScreenViewModel insertScreenViewModel { get; set; }

        public SearchViewModel searchViewModel { get; set; }

        public MainScreenViewModel()
        {
            insertScreenViewModel= new InsertScreenViewModel();
            searchViewModel= new SearchViewModel();
        }
    }
}
