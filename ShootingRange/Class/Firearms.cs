using ShootingRange.Enums;
using ShootingRange.Interfaces;

namespace ShootingRange.Class
{
    public class Firearms : IShootingRangeService
    {
        public double ShotCost;
        public uint ShotCount;
        public EnumFirearms FirearmType;

        public Firearms (EnumFirearms firearmType)
        {
            FirearmType = firearmType;
            ShotCost = 1;
        }

        public double ShootingSingleCost(uint numberOfShots)
        {
            ShotCount = numberOfShots;
            return ShotCost * numberOfShots;
        }

        public double ShootingAutoCost(uint numberOfShots)
        {
            return ShotCost * numberOfShots * 1.15;
        }
    }
}
