using AlxCourseHomework.MaterialsAssignments.Classes;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class WarehouseService
    {
        List<WarehouseItem> Warehouse;

        public WarehouseService()
        {
            Warehouse = new List<WarehouseItem>();
        }

        public void StoreInWarehouse(WarehouseItem warehouseItem)
        {
            Warehouse.Add(warehouseItem);
        }

        public void PrintLabels()
        {
            Present(Warehouse);
            Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
            Console.ReadKey();
        }

        public void PresentBrutto()
        {
            CountBruttoPrice(Warehouse);
            Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
            Console.ReadKey();
        }

        public void PresentWarehouseValue()
        {
            CountWarehouseValue(Warehouse);
            Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
            Console.ReadKey();
        }

        public void Present(List<WarehouseItem> list)
        {
            foreach (WarehouseItem warehouseItem in list)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Id: {warehouseItem.Id}");
                Console.WriteLine($"Cena netto: {warehouseItem.PriceNetto}");
                Console.WriteLine($"Stawka VAT: {warehouseItem.VATRate}%");
                double taxAmount = Math.Round(warehouseItem.PriceNetto * warehouseItem.VATRate / 100, 2);
                double bruttoPrice = Math.Round(warehouseItem.PriceNetto + taxAmount, 2);
                Console.WriteLine($"Cena brutto: {bruttoPrice}");
                Console.WriteLine($"Cena za pudełko: {Math.Round(bruttoPrice * warehouseItem.QuantityInBox, 2)}");
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
        }

        public void CountBruttoPrice(List<WarehouseItem> list)
        {
            foreach (WarehouseItem warehouseItem in list)
            {
                Console.WriteLine("------------------------");
                // Console.WriteLine($"Id: {warehouseItem.Id}");
                double taxAmount = Math.Round(warehouseItem.PriceNetto * warehouseItem.VATRate / 100, 2);
                double bruttoPrice = Math.Round(warehouseItem.PriceNetto + taxAmount, 2);
                Console.WriteLine($"Cena brutto towaru {warehouseItem.Id}: {bruttoPrice}");
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
        }

        public void CountWarehouseValue(List<WarehouseItem> list)
        {
            foreach (WarehouseItem warehouseItem in list)
            {
                Console.WriteLine("------------------------");
                // Console.WriteLine($"Id: {warehouseItem.Id}");
                double taxAmount = Math.Round(warehouseItem.PriceNetto * warehouseItem.VATRate / 100, 2);
                double bruttoPrice = Math.Round(warehouseItem.PriceNetto + taxAmount, 2);
                Console.WriteLine($"Wartość towaru {warehouseItem.Id} w magazynie: {Math.Round(bruttoPrice * warehouseItem.QuantityInBox * warehouseItem.NumberOfBoxes, 2)}");
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
        }
    }
}
