namespace Insidiae.Library
{
    public class NonPlayerCharacter : BaseNameDescription
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
}