namespace AlxCourseHomework.Workers.Classes
{
    public class Worker
    {
        public string Name;
        public string Surname;
        public string Contract;


        Etat etat = new Etat();
        Staz staz = new Staz();

        public Worker(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Contract = "Staż";
        }
        public Worker()
        {
        }

        public void ChangeContract(string contract)
        {
            Contract = contract;
        }

        public double Pay()
        {
            if (Contract.ToLower() == "etat")
            {
                return Math.Round(etat.CalculatePay(),2);
            }
            else
            {
                return Math.Round(staz.CalculatePay(),2);
            }
        }

        public string Present()
        {
            return Name + " " + Surname + " Pay: " + Pay().ToString();
        }
    }
}
