using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyLookup.Models
{
    public class FLightDataModel : IFlightDataModel
    {
        public double ARV { get; set; }
        public double INC { get; set; }
        public double AZI { get; set; }
        public double TRV { get; set; }
	      public double ALT { get; set; }
        public double NS { get; set; }
        public double EW { get; set; }


    }
}
