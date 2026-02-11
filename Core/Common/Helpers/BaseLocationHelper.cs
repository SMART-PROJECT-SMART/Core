using Core.Common.Enums;
using Core.Models;

namespace Core.Common.Helpers
{
    public static class BaseLocationHelper
    {
        private static readonly Dictionary<BaseLocation, Location> _baseToLocation = new()
        {
            { BaseLocation.Hatzerim, new Location(31.2333, 34.6625, 0) },
            { BaseLocation.TelNof, new Location(31.8394, 34.8217, 0) },
            { BaseLocation.RamatDavid, new Location(32.6656, 35.1817, 0) },
            { BaseLocation.Nevatim, new Location(31.2083, 35.0122, 0) },
            { BaseLocation.Ramon, new Location(30.7761, 34.6667, 0) },
            { BaseLocation.Hatzor, new Location(31.7625, 34.7272, 0) },
            { BaseLocation.Palmachim, new Location(31.8978, 34.6906, 0) },
            { BaseLocation.Ovda, new Location(29.94, 34.9358, 0) }
        };

        public static Location GetLocation(BaseLocation baseLocation)
        {
            return _baseToLocation[baseLocation];
        }

        public static BaseLocation GetBaseLocation(Location location)
        {
            const double tolerance = 0.01;

            foreach (var (baseLocation, baseCoords) in _baseToLocation)
            {
                if (Math.Abs(location.Latitude - baseCoords.Latitude) < tolerance &&
                    Math.Abs(location.Longitude - baseCoords.Longitude) < tolerance)
                {
                    return baseLocation;
                }
            }

            throw new ArgumentException($"Location ({location.Latitude}, {location.Longitude}) does not match any known base location.");
        }
    }
}
