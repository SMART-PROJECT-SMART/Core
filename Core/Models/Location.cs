namespace Core.Models
{
    public struct Location(double latitude, double longitude, double altitude)
    {
        public double Latitude { get; set; } = latitude;
        public double Longitude { get; set; } = longitude;
        public double Altitude { get; set; } = altitude;

        public double CalculateDistanceTo(Location targetLocation)
        {
            double latitudeDifference = Latitude - targetLocation.Latitude;
            double longitudeDifference = Longitude - targetLocation.Longitude;
            double altitudeDifference = Altitude - targetLocation.Altitude;

            double horizontalDistanceSquared =
                (latitudeDifference * latitudeDifference) + (longitudeDifference * longitudeDifference);
            double verticalDistanceSquared = altitudeDifference * altitudeDifference;

            double totalDistanceSquared = horizontalDistanceSquared + verticalDistanceSquared;
            double distance = Math.Sqrt(totalDistanceSquared);

            return distance;
        }
    }
}
