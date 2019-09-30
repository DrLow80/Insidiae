namespace Insidiae.Library
{
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
}