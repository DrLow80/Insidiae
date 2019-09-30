using System.Runtime.InteropServices.WindowsRuntime;
using Insidiae.AdventureFeature.Views;
using Insidiae.Library;
using Insidiae.ViewModel;
using Spring.Context.Attributes;

namespace Insidiae.WPF.Features.Adventure
{
    [Configuration]
    public class AdventureConfiguration
    {
        [Definition]
        public virtual AdventureHostViewModel AdventureHostViewModel()
        {
            return new AdventureHostViewModel();
        }

        [Definition]
        public virtual AdventureListViewModel AdventureListViewModel()
        {
            return new AdventureListViewModel();
        }

        [Definition]
        public virtual AdventureViewModel AdventureViewModel()
        {
            return new AdventureViewModel();
        }

        [Definition]
        public virtual EncounterViewModel EncounterViewModel()
        {
            var encounterViewModel = new EncounterViewModel();

            encounterViewModel.EditCommand = new RelayCommand<TurningPoint>(x => { encounterViewModel.TurningPoint = x; });

            return encounterViewModel;
        }



        [Definition]
        public virtual PlotPointViewModel PlotPointViewModel()
        {
            return new PlotPointViewModel();
        }
    }
}