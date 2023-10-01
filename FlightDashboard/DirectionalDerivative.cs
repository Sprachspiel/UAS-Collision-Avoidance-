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
                - aero[I - 1].INC)
                - (Math.Sin(aero[I - 1].INC)
                * Math.Sin(aero[I].INC))
                * (1 - Math.Cos(aero[I].AZI
                - aero[I - 1].AZI)));
        }
    }
}
