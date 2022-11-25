using ShootingRange.Enums;
using ShootingRange.Interfaces;

namespace ShootingRange.Class
{
    public class Firearms
    {
        public double ShotCost;
        public uint ShotCount = 1;
        public EnumFirearms FirearmType;
        public bool HasAuto = true;

        public Firearms ()
        {
        }

        public double SingleShotCost(uint numberOfShots)
        {
            ShotCount = numberOfShots;
            return ShotCost * numberOfShots;
        }

        public double AutoShotCost(uint numberOfShots)
        {
            return ShotCost * numberOfShots * 1.15;
        }
    }
}
