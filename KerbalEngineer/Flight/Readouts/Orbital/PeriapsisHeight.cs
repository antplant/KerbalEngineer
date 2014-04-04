﻿// Project:	KerbalEngineer
// Author:	CYBUTEK
// License:	Attribution-NonCommercial-ShareAlike 3.0 Unported

namespace KerbalEngineer.Flight.Readouts.Orbital
{
    public class PeriapsisHeight : ReadoutModule
    {
        public PeriapsisHeight()
        {
            this.Name = "Periapsis Height";
            this.Category = ReadoutCategory.Orbital;
            this.HelpString = "Shows the vessel's periapsis height relative to sea level. (Periapsis is the lowest point of an orbit.";
        }

        public override void Draw()
        {
            this.DrawLine(FlightGlobals.ActiveVessel.orbit.PeA.ToString("N0") + "m");
        }
    }
}