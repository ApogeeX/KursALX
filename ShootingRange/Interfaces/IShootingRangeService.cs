namespace ShootingRange.Interfaces
{
    internal interface IShootingRangeService
    {
        double ShootingSingleCost(uint numberOfShots);
        double ShootingAutoCost(uint numberOfShots);
    }
}
