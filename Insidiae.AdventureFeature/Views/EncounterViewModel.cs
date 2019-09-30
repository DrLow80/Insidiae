using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Insidiae.Library;
using Insidiae.ViewModel;

namespace Insidiae.AdventureFeature.Views
{
    public class EncounterViewModel : BaseViewModel
    {
        //public Encounter Encounter { get; set; }

        public TurningPoint TurningPoint { get; set; }

        public ICommand EditCommand { get; set; }
    }
}
