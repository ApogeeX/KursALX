using ShootingRange.Enums;

namespace ShootingRange.Class
{
    public class Scorpion : Firearms
    {
        public Scorpion() : base()
        {
            FirearmType = EnumFirearms.SCORPION;
            ShotCost = 0.55;
        }
    }
}
