using System;
using System.Linq;

namespace TreehouseDefense
{
    public class Path
    {
        private MapLocation[] _path;

        public Path(MapLocation[] pathLocations)
        {
            this._path = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation) //=> _path.Contains(mapLocation);
        {
            int index = Array.FindIndex(_path, (x) => x.X == mapLocation.X && x.Y == mapLocation.Y);

            return index >= 0 ? true : false;
        }
    }
}