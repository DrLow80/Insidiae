using System.Collections.Generic;
using System.Collections.ObjectModel;
using Insidiae.Library;
using Insidiae.ViewModel;

namespace Insidiae.AdventureFeature.Views
{
    public class AdventureListViewModel : BaseViewModel
    {
        public AdventureListViewModel()
        {
            Adventures.Add(new Adventure());
        }

        public ObservableCollection<Adventure> Adventures { get; set; } = new ObservableCollection<Adventure>();
    }

    

}