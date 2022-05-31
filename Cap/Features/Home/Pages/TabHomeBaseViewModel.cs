using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap
{
    public class TabHomeBaseViewModel : BaseModel
    {
        public TabHomeBaseViewModel()
        {
            TabHomeModel tab1 = new TabHomeModel();
            tab1.Title = "Chuyện 2 ta";
            Items.Add(tab1);
            TabHomeModel tab2 = new TabHomeModel();
            tab1.Title = "Tường nhà";
            Items.Add(tab2);
        }
        public ObservableCollection<TabHomeModel> Items { get; set; } = new ObservableCollection<TabHomeModel>();   
    }
}
