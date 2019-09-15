using System.Collections.ObjectModel;
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

            PresentMilieuEvents = new ObservableCollection<MilieuEvent>
            {
                new MilieuEvent(),
                new MilieuEvent(),
                new MilieuEvent()
            };

            FutureMilieuEvents = new ObservableCollection<MilieuEvent>
            {
                new MilieuEvent(),
                new MilieuEvent(),
                new MilieuEvent()
            };

            MajorNonPlayerCharacters = new ObservableCollection<NonPlayerCharacter>
            {
                new NonPlayerCharacter(),
                new NonPlayerCharacter(),
                new NonPlayerCharacter()
            };

            MinorNonPlayerCharacters = new ObservableCollection<NonPlayerCharacter>
            {
                new NonPlayerCharacter(),
                new NonPlayerCharacter(),
                new NonPlayerCharacter()
            };

            MajorMonsters = new ObservableCollection<Monster>
            {
                new Monster(),
                new Monster(),
                new Monster()
            };

            MinorMonsters = new ObservableCollection<Monster>
            {
                new Monster(),
                new Monster(),
                new Monster()
            };

            PlotPoints = new ObservableCollection<PlotPoint>
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