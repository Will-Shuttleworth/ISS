namespace ISS.Model;

class SpaceStationPositionRoot
{
    public int Timestamp { get; set; }
    public string Message { get; set; }
    public SpaceStationPosition SpaceStationPositions { get; set; }
}

