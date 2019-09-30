namespace Insidiae.Library
{
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
}