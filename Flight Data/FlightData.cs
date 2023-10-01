using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyLookup.DataAccess;
using SurveyLookup.Models;

namespace SurveyLookup.Data
{
    public class FlightData
    {
        private readonly SqlDataAccess _dataAccess;

        public FlightData(SqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<IFlightDataModel>> GetFlightData()
        {
            var flightPath = await _dataAccess.LoadData<FlightDataModel, dynamic>("dbo.spSurveyLookup",
                                                                                   new { },
                                                                                   "DefaultConnection");
            return flightPath.ToList<IFlightDataModel>();
        }
    }
}
