using System;
using System.Collections.Generic;

namespace advent
{
    public static class Day3
    {
        public static int Problem1(int address)
        {
            (int layer, int stepsToCenter) location = CalculateLocation(address);

            return location.layer + location.stepsToCenter;
        }

        public static ValueTuple<int, int> CalculateLocation(int address)
        {
            var location = (layer: 0, stepsToCenter: 0);
            if (address == 1)
            {
                return location;
            }
            var sideSize = 1;
            for (var memAddress = 1; memAddress <= address; location.layer++, sideSize += 2)
            {

                var center = sideSize / 2;

                for (var side = 0; side < 4; side++)
                {
                    if (memAddress == 1)
                    {
                        memAddress++;
                        break;
                    }
                    for (var sidePosition = 1; sidePosition < sideSize && memAddress <= address; sidePosition++, memAddress++)
                    {
                        location.stepsToCenter = Math.Abs(sidePosition - center);
                        if (memAddress == address)
                        {
                            return location;
                        }
                    }
                }
            }
            return location;
        }

        public static int Problem2(int value)
        {
            var current = new Dictionary<(int sideIndex, int side), int>();
            var inner = new Dictionary<(int sideIndex, int side), int>
            {
                [(sideIndex: 0, side: 0)] = 1,
                [(sideIndex: 0, side: 1)] = 1,
                [(sideIndex: 0, side: 2)] = 1,
                [(sideIndex: 0, side: 3)] = 1
            };

            for (var sideSize = 3;;inner = new Dictionary<(int sideIndex, int side), int>(current), sideSize += 2)
            {
                var location = (sideIndex: 0, side: 0);
                current.Clear();

                for (location.side = 0; location.side < 4; location.side++)
                {
                    var locationValue = 0;
                    for (location.sideIndex = 1; location.sideIndex < sideSize; location.sideIndex++)
                    {
                        locationValue = GetLocationValue(location, current, inner, sideSize);
                        if (locationValue > value)
                        {
                            return locationValue;
                        }
                        current[(location.sideIndex, location.side)] = locationValue;
                    }
                    if (location.side != 3)
                    {
                        current[(0, location.side + 1)] = locationValue;
                    }
                    else
                    {
                        current[(0, 0)] = locationValue;
                    }
                }
            }
        }

        private static int GetLocationValue((int sideIndex, int side) currentLocation, Dictionary<(int sideIndex, int side), int> currentLayer,
            Dictionary<(int sideIndex, int side), int> innerLayer, int sideSize)
        {
            var sum = 0;
            for (var i = currentLocation.sideIndex - 2; i < currentLocation.sideIndex + 1; i++)
            {
                if (i == -1 && currentLocation.side != 0)
                {
                    sum += currentLayer[(sideSize - 2, currentLocation.side - 1)];
                }
                if (i >= 0 && i < sideSize - 2)
                {
                    sum += innerLayer[(i, currentLocation.side)];
                }
            }

            if (currentLocation.side == 3 && currentLocation.sideIndex >= sideSize - 2)
            {
                sum += currentLayer[(1, 0)];
            }

            if (currentLocation.sideIndex - 1 >= 0 && !currentLocation.Equals((1,0)))
            {
                sum += currentLayer[(currentLocation.sideIndex - 1, currentLocation.side)];
            }
            return sum;
        }
    }
}
