// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToTerraServerProvider
{
    public class Place
    {
        // Properties.
        public string Name { get; private set; }
        public string State { get; private set; }
        public PlaceType PlaceType { get; private set; }

        // Constructor.
        internal Place(string name,
                        string state,
                        LinqToTerraServerProvider.TerraServerReference.PlaceType placeType)
        {
            Name = name;
            State = state;
            PlaceType = (PlaceType)placeType;
        }
    }

    public enum PlaceType
    {
        Unknown,
        AirRailStation,
        BayGulf,
        CapePeninsula,
        CityTown,
        HillMountain,
        Island,
        Lake,
        OtherLandFeature,
        OtherWaterFeature,
        ParkBeach,
        PointOfInterest,
        River
    }
}
