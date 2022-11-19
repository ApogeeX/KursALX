using AlxCourseHomework.MaterialsAssignments;
using AlxCourseHomework.MaterialsAssignments.Classes;


namespace AlxCourseHomework
{
    public class Page21
    {
        public static void Run()
        {
            WarehouseService warehouseService = new WarehouseService();

            var warehouseItem1 = new WarehouseItem(1, 3.58, 5, 10, 2);
            var warehouseItem2 = new WarehouseItem(2, 9.61, 5, 25, 5);
            var warehouseItem3 = new WarehouseItem(3, 8.52, 8, 18, 3);
            var warehouseItem4 = new WarehouseItem(4, 10.25, 8, 36, 6);
            var warehouseItem5 = new WarehouseItem(5, 5.17, 23, 4, 1);
            int loop = 0;

            warehouseService.StoreInWarehouse(warehouseItem1);
            warehouseService.StoreInWarehouse(warehouseItem2);
            warehouseService.StoreInWarehouse(warehouseItem3);
            warehouseService.StoreInWarehouse(warehouseItem4);
            warehouseService.StoreInWarehouse(warehouseItem5);

            do
            {
                Console.Clear();
                Console.WriteLine("Please choose option: ");
                Console.WriteLine("P - Print Labels.");
                Console.WriteLine("B - Show Brutto prices.");
                Console.WriteLine("V - Show warehouse value per item.");
                Console.WriteLine("Q - Quit program.");
                char option = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (option.ToString().ToLower())
                {
                    case "p":
                        warehouseService.PrintLabels();
                        break;
                    case "b":
                        warehouseService.PresentBrutto();
                        break;
                    case "v":
                        warehouseService.PresentWarehouseValue();
                        break;
                    default:
                        loop = 1;
                        break;
                }
            } while (loop == 0);
        }
    }
}
