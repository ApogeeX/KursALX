using ShootingRange.Enums;

namespace ShootingRange.Class
{
    public class AK47 : Firearms
    {
        public AK47() : base()
        {
            FirearmType = EnumFirearms.AK47;
            ShotCost = 0.33;
        }
    }
}
