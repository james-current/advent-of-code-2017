using System;
using System.ComponentModel;

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
    }
}
