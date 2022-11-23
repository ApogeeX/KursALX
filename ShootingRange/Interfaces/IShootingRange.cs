namespace ShootingRange.Interfaces
{
    internal interface IShootingRange
    {
        double ShootingSingleCost(uint numberOfShots);
        double ShootingAutoCost(uint numberOfShots);
    }
}
