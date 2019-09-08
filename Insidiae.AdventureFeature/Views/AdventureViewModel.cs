using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insidiae.ViewModel;

namespace Insidiae.AdventureFeature.Views
{
    public class AdventureViewModel : BaseViewModel
    {
        public AdventureViewModel()
        {
            Adventure = new Adventure();

            PastMilieuEvents = new ObservableCollection<MilieuEvent>
            {
                new MilieuEvent(),
                new MilieuEvent(),
                new MilieuEvent()
            };

            this.PresentMilieuEvents = new ObservableCollection<MilieuEvent>
            {
                new MilieuEvent(),
                new MilieuEvent(),
                new MilieuEvent()
            };

            this.FutureMilieuEvents = new ObservableCollection<MilieuEvent>
            {
                new MilieuEvent(),
                new MilieuEvent(),
                new MilieuEvent()
            };

            this.MajorNonPlayerCharacters = new ObservableCollection<NonPlayerCharacter>
            {
                new NonPlayerCharacter(),
                new NonPlayerCharacter(),
                new NonPlayerCharacter(),
            };

            this.MinorNonPlayerCharacters = new ObservableCollection<NonPlayerCharacter>
            {
                new NonPlayerCharacter(),
                new NonPlayerCharacter(),
                new NonPlayerCharacter(),
            };

            this.MajorMonsters = new ObservableCollection<Monster>
            {
                new Monster(),
                new Monster(),
                new Monster(),
            };

            this.MinorMonsters = new ObservableCollection<Monster>
            {
                new Monster(),
                new Monster(),
                new Monster(),
            };

            this.PlotPoints=new ObservableCollection<PlotPoint>
            {
                new PlotPoint(),
                new PlotPoint(),
                new PlotPoint()
            };
        }

        public Adventure Adventure { get; set; }
        public ObservableCollection<MilieuEvent> PastMilieuEvents { get; set; }
        public ObservableCollection<MilieuEvent> PresentMilieuEvents { get; set; }
        public ObservableCollection<MilieuEvent> FutureMilieuEvents { get; set; }
        public ObservableCollection<NonPlayerCharacter> MajorNonPlayerCharacters { get; set; }
        public ObservableCollection<NonPlayerCharacter> MinorNonPlayerCharacters { get; set; }
        public ObservableCollection<Monster> MajorMonsters { get; set; }
        public ObservableCollection<Monster> MinorMonsters { get; set; }
        public ObservableCollection<PlotPoint> PlotPoints { get; set; }
    }
}
