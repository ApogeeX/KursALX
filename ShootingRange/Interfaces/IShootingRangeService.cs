namespace ShootingRange.Interfaces
{
    internal interface IShootingRangeService
    {
        double SingleShotCost(uint numberOfShots);
        double AutoShotCost(uint numberOfShots);
    }
}
