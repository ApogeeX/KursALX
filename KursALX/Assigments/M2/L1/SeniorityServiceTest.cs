namespace KursALX.Assigments.M2.L1
{
    public static class SeniorityServiceTest
    {
        public static void Run()
        {
            var employee1 = new Employee("Emil", 5000, 5);
            var employee2 = new Employee("Karol", 10000, 10);
            var employee3 = new Employee("Paweł", 13000, 13);
            var employee4 = new Employee("Jacek", 3000, 3);
            var employee5 = new Employee("Tomek", 4000, 4);
            var employee6 = new Employee("Maria", 8000, 4);
            var employee7 = new Employee("Cezary", 7000, 2);
            var employee8 = new Employee("Karolina", 8000, 13);
            var employee9 = new Employee("Urszula", 10000, 8);

            var seniorityService = new SeniorityService();
            seniorityService.ClassifySeniorityBySalary(employee1);
            seniorityService.ClassifySeniorityBySalary(employee2);
            seniorityService.ClassifySeniorityBySalary(employee3);
            seniorityService.ClassifySeniorityBySalary(employee4);
            seniorityService.ClassifySeniorityBySalary(employee5);
            seniorityService.ClassifySeniorityBySalary(employee6);
            seniorityService.ClassifySeniorityBySalary(employee7);
            seniorityService.ClassifySeniorityBySalary(employee8);
            seniorityService.ClassifySeniorityBySalary(employee9);
            Console.WriteLine("Juniors by salary: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids by salary: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors by salary: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine("");

            seniorityService.ClearLists();

            seniorityService.ClassifySeniorityByExperience(employee1);
            seniorityService.ClassifySeniorityByExperience(employee2);
            seniorityService.ClassifySeniorityByExperience(employee3);
            seniorityService.ClassifySeniorityByExperience(employee4);
            seniorityService.ClassifySeniorityByExperience(employee5);
            seniorityService.ClassifySeniorityByExperience(employee6);
            seniorityService.ClassifySeniorityByExperience(employee7);
            seniorityService.ClassifySeniorityByExperience(employee8);
            seniorityService.ClassifySeniorityByExperience(employee9);
            Console.WriteLine("Juniors by experience: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids by experience: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors by experience: ");
            PresentEmployees(seniorityService.SeniorEmployees);
        }

        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");
            }
        }
    }
}
