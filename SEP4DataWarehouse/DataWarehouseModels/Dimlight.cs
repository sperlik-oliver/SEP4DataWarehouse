﻿using System;
using System.Collections.Generic;

namespace SEP4DataWarehouse.DataWarehouseModels
{
    public partial class Dimlight
    {
        public Dimlight()
        {
            Factmeasurements = new HashSet<Factmeasurement>();
        }

        public int LId { get; set; }
        public int? Lightid { get; set; }
        public float? Upperlimit { get; set; }
        public float? Lowerlimit { get; set; }
        public int? MeasureDate { get; set; }
        public int? Validfrom { get; set; }
        public int? Validto { get; set; }
        public string? Wastriggered { get; set; }
        public string? Istop { get; set; }

        public virtual ICollection<Factmeasurement> Factmeasurements { get; set; }
    }
}
