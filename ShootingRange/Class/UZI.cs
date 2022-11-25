using ShootingRange.Enums;

namespace ShootingRange.Class
{
    public class UZI : Firearms
    {
        public UZI() : base()
        {
            FirearmType = EnumFirearms.UZI;
            ShotCost = 0.30;
        }
    }
}
