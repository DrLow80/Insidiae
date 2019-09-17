using System.Collections.Generic;
using System.Collections.ObjectModel;
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

    public class Adventure
    {
        public Adventure()
        {
            AdventureTheme = "Adventure Theme";
            AdventureTitle = "Adventure Title";
            CampaignDate = "Campaign Date";
            CampaignEpisodeNumber = "Campaign Episode Number";
            Date = "Date";
            GameMaster = "Game Master";
            OriginationLocale = "Origination Locale";
        }

        public string AdventureTitle { get; set; }

        public string Date { get; set; }

        public string GameMaster { get; set; }

        public string CampaignDate { get; set; }

        public string CampaignEpisodeNumber { get; set; }

        public string OriginationLocale { get; set; }

        public string AdventureTheme { get; set; }
    }

    public class Monster
    {
        public Monster()
        {
            Name = "Name";
            Class = "Class";
            Goals = "Goals";
            PrimaryMotivation = "Primary Motivation";
            StoryRole = "Story Role";
            Type = "Type";
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Goals { get; set; }
        public string StoryRole { get; set; }
        public string PrimaryMotivation { get; set; }
    }

    public class NonPlayerCharacter:BaseNameDescription
    {
        public NonPlayerCharacter()
        {
            Class = "Class";
            Goals = "Goals";
            Name = "Name";
            PrimaryMotivation = "Primary Motivation";
            Race = "Race";
            Sex = "Sex";
            SocialClass = "Social Class";
            StoryRole = "Story Role";
            Description = "Description";
        }

        public string Race { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }
        public string SocialClass { get; set; }
        public string Goals { get; set; }
        public string StoryRole { get; set; }
        public string PrimaryMotivation { get; set; }
    }

    public class MilieuEvent
    {
        public MilieuEvent()
        {
            Content = "Content";
        }

        public string Content { get; set; }
    }

    public class PlotPoint
    {
        public PlotPoint()
        {
            Act = "Act";
            IncitingIncident = "Inciting Incident";
            PrimaryEndpoint = "Primary Endpoint";
            TurningPoints = new List<TurningPoint> { new TurningPoint(), new TurningPoint(), new TurningPoint() };
        }

        public string Act { get; set; }
        public string IncitingIncident { get; set; }
        public string PrimaryEndpoint { get; set; }
        public ICollection<TurningPoint> TurningPoints { get; set; }
    }

    public class TurningPoint
    {
        public TurningPoint()
        {
            Content = "Content";
        }

        public string Content { get; set; }
    }

    public abstract class BaseNameDescription
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Goal : BaseNameDescription
    {

    }

    public class EncounterType : BaseNameDescription
    {

    }

    public class StoryFunction : BaseNameDescription
    {

    }

}