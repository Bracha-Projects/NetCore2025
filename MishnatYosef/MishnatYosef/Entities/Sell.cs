namespace MishnatYosef.Entities
{
    public class Sell
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public DateTime ClosingTime { get; set; }
        public int day { get; set; }
        public string SellHours { get; set; }
        public int Station { get; set; }

        public Sell(int id, int type, DateTime closingTime, int day, string sellHours, int station)
        {
            Id = id;
            Type = type;
            ClosingTime = closingTime;
            this.day = day;
            SellHours = sellHours;
            Station = station;
        }
        public Sell()
        {
            
        }
    }
}
