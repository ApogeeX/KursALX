using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.M2
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

            var seniorityServiceBySalary = new SeniorityService();
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee1);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee2);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee3);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee4);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee5);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee6);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee7);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee8);
            seniorityServiceBySalary.ClassifySeniorityBySalary(employee9);

            var seniorityServiceByExperience = new SeniorityService();
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee1);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee2);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee3);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee4);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee5);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee6);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee7);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee8);
            seniorityServiceByExperience.ClassifySeniorityByExperience(employee9);
            
            Console.WriteLine("Juniors by experience: ");
            PresentEmployees(seniorityServiceByExperience.JuniorEmployees);

            Console.WriteLine("Mids by experience: ");
            PresentEmployees(seniorityServiceByExperience.MidEmployees);

            Console.WriteLine("Seniors by experience: ");
            PresentEmployees(seniorityServiceByExperience.SeniorEmployees);

            Console.WriteLine("");

            Console.WriteLine("Juniors by salary: ");
            PresentEmployees(seniorityServiceBySalary.JuniorEmployees);

            Console.WriteLine("Mids by salary: ");
            PresentEmployees(seniorityServiceBySalary.MidEmployees);

            Console.WriteLine("Seniors by salary: ");
            PresentEmployees(seniorityServiceBySalary.SeniorEmployees);
        }

        public static void PresentEmployees(List<Employee> employees)
        {
            foreach(var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");
            }
        }
    }
}
