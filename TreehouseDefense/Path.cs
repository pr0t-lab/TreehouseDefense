using System;

namespace TreehouseDefense
{
    public class Path
    {
        private MapLocation[] pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            this.pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation)
        {
            int index = Array.FindIndex(pathLocations, (x) => x.X == mapLocation.X && x.Y == mapLocation.Y);

            return index >= 0 ? true : false;
        }
    }
}