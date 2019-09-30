using System.Collections.Generic;

namespace Insidiae.Library
{
    public class PlotPoint
    {
        public PlotPoint()
        {
            Act = "Act";
            IncitingIncident = new TurningPoint();
            PrimaryEndpoint = new TurningPoint();
            TurningPoints = new List<TurningPoint> { new TurningPoint(), new TurningPoint(), new TurningPoint() };
        }

        public string Act { get; set; }
        public TurningPoint IncitingIncident { get; set; }
        public TurningPoint PrimaryEndpoint { get; set; }
        public ICollection<TurningPoint> TurningPoints { get; set; }
    }
}