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
        public string AdventureTitle { get; set; }

        public string Date { get; set; }

        public string GameMaster { get; set; }

        public string CampaignDate { get; set; }

        public string CampaignEpisodeNumber { get; set; }

        public string OriginationLocale { get; set; }

        public string AdventureTheme { get; set; }

        public Adventure()
        {
            this.AdventureTheme = "Adventure Theme";
            this.AdventureTitle = "Adventure Title";
            this.CampaignDate = "Campaign Date";
            this.CampaignEpisodeNumber = "Campaign Episode Number";
            this.Date = "Date";
            this.GameMaster = "Game Master";
            this.OriginationLocale = "Origination Locale";
        }
    }

    public class Monster
    {
        public Monster()
        {
            this.Name = "Name";
            this.Class = "Class";
            this.Goals = "Goals";
            this.PrimaryMotivation = "Primary Motivation";
            this.StoryRole = "Story Role";
            this.Type = "Type";
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Goals { get; set; }
        public string StoryRole { get; set; }
        public string PrimaryMotivation { get; set; }
    }

    public class NonPlayerCharacter
    {
        public NonPlayerCharacter()
        {
            this.Class = "Class";
            this.Goals = "Goals";
            this.Name = "Name";
            this.PrimaryMotivation = "Primary Motivation";
            this.Race = "Race";
            this.Sex = "Sex";
            this.SocialClass = "Social Class";
            this.StoryRole = "Story Role";
        }

        public string Name { get; set; }
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
            this.Content = "Content";
        }
        public string Content { get; set; }
    }

    public class PlotPoint
    {
        public string Act { get; set; }
        public string IncitingIncident { get; set; }
        public string PrimaryEndpoint { get; set; }
        public ICollection<TurningPoint> TurningPoints { get; set; }

        public PlotPoint()
        {
            this.Act = "Act";
            this.IncitingIncident = "Inciting Incident";
            this.PrimaryEndpoint = "Primary Endpoint";
            this.TurningPoints = new List<TurningPoint> { new TurningPoint(), new TurningPoint(), new TurningPoint() };
        }
    }

    public class TurningPoint
    {
        public string Content { get; set; }

        public TurningPoint()
        {
            this.Content = "Content";
        }
    }
}
