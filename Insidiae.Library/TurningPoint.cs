namespace Insidiae.Library
{
    public class TurningPoint
    {
        public TurningPoint()
        {
            Name = "Name";
            EncounterType = "Encounter Type";
            EncounterFunction = "Encounter Function";
            AssociatedGoal = "AssociatedGoal";
            PlotElement = "Plot Element";
            Location = "Location";
            Content = "Content";
            BoundTriggers = "Bound Triggers";
            UnboundTriggers = "Unbound Triggers";
        }

        public string Content { get; set; }

        public string Name { get; set; }
        public string EncounterType { get; set; }
        public string EncounterFunction { get; set; }
        public string AssociatedGoal { get; set; }
        public string PlotElement { get; set; }
        public string Location { get; set; }
        public string BoundTriggers { get; set; }
        public string UnboundTriggers { get; set; }

    }
}