namespace SurveyLookup.Models
{
    public interface IFlightDataModel
    {
        double AZI { get; set; }
        double EW { get; set; }
        double INC { get; set; }
        double ARV { get; set; }
        double NS { get; set; }
        double ALT { get; set; }
	      double TRV { get; set; }
    }
}
