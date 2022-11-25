using ShootingRange.Enums;

namespace ShootingRange.Class
{
    public class M4 : Firearms
    {
        public M4() : base()
        {
            FirearmType = EnumFirearms.M4;
            ShotCost = 0.28;
        }
    }
}
