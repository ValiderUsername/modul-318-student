namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;
    using System;
    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Stations GetStations(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id);

        StationBoardRoot GetStationBoard(string station, string id);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation);

        Connections GetConnectionsWithTime(string fromStation, string toStation, DateTime dateTime);

        Task<Connections> GetConnectionsWithTimeAsync(string fromStation, string toStation, DateTime dateTime);
    }
}