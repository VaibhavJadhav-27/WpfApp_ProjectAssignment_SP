using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ProjectAssignment_SP.Utilities
{
    public class DataAccess
    {
        public ObservableCollection<USP_SearchProductRecords_Result> FetchData(string productname,string productcode,string brandid, string categoryids,string producttype)
        {
            using(var db = new DemoEntities())
            {
                var productrecordslist = db.USP_SearchProductRecords(productname,productcode,brandid,categoryids,producttype).ToList();
                ObservableCollection<USP_SearchProductRecords_Result> filteredlist = new ObservableCollection<USP_SearchProductRecords_Result>(productrecordslist);
                return filteredlist;
            }
        }
    }
}
