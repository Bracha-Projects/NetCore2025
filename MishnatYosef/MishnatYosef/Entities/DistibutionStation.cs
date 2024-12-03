namespace MishnatYosef.Entities
{
    public class DistibutionStation
    {
        public int Station { get; set; }
        public string StationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StationManagerName { get; set; }
        public string StationManagerPhone { get; set; }
        public string StationUsherName { get; set; }
        public string StationUsherPhone { get; set; }
        public int MaximumCapacity { get; set; }

        public DistibutionStation(int station, string stationName, string address, string city, string stationManagerName, string stationManagerPhone, string stationUsherName, string stationUsherPhone, int maximumCapacity)
        {
            Station = station;
            StationName = stationName;
            Address = address;
            City = city;
            StationManagerName = stationManagerName;
            StationManagerPhone = stationManagerPhone;
            StationUsherName = stationUsherName;
            StationUsherPhone = stationUsherPhone;
            MaximumCapacity = maximumCapacity;
        }
        public DistibutionStation()
        {
            
        }
    }
}
