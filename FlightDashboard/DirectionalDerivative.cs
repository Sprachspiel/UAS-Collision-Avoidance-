@using SurveyLookup.Data
@inject FlightData flightData
@using FlightDashboard.Data.Models

@code {

    private List<IFlightDataModel> flight;

    protected override async Task OnParametersSetAsync()
    {
        var aero = await flightData.GetFlightData();
        for (int i = 1; i < ft.Count; i++)
        {
            aero[I].DirectionalDerivative = Math.Acos(Math.Cos(aero[I].INC
                - aero[i - 1].INC)
                - (Math.Sin(aero[i - 1].INC)
                * Math.Sin(aero[i].INC))
                * (1 - Math.Cos(aero[i].AZI
                - aero[i - 1].AZI)));
        }
    }
}
