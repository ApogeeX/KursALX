using ShootingRange.Enums;

namespace ShootingRange.Class
{
    public class Beretta : Firearms
    {
        public Beretta() : base()
        {
            FirearmType = EnumFirearms.BERETTA;
            HasAuto = false;
            ShotCost = 0.25;
        }
    }
}
