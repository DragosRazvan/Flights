namespace Flights.Server.ReadModels
{
    public record FlightRm(Guid Id, string Airline, string Price, TimePlaceRm Departue, TimePlaceRm Arrival, int RemainingNumberOfSeats);
}
