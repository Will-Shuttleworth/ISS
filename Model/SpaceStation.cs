namespace ISS.Model;


public class SpaceStation : ObservableObject
{
    public class IssPosition
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class Root
    {
        public int Timestamp { get; set; }
        public string Message { get; set; }
        public IssPosition Iss_Position { get; set; }
    }
}

