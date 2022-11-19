namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class WarehouseItem
    {
        public int Id;
        public double PriceNetto;
        public int VATRate;
        public int QuantityInBox;
        public int NumberOfBoxes;

        public WarehouseItem(int id, double priceNetto, int vatRate, int quantityInBox, int numberOfBoxes)
        {
            Id = id;
            PriceNetto = priceNetto;
            VATRate = vatRate;
            QuantityInBox = quantityInBox;
            NumberOfBoxes = numberOfBoxes;
        }

    }
}
