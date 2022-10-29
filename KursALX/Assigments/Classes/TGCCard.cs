namespace KursALX.Assigments.Classes
{
    public class TCGCard
    {
        public string GameTitle;
        public bool IsRare;
        public int CardNumber;
        public string Name;

        public TCGCard(int cardNumber)
        {
            CardNumber = cardNumber;
        }
        public TCGCard (string gameTitle, bool isRare, int cardNumber, string name)
        {
            GameTitle = gameTitle;
            IsRare = isRare;
            CardNumber = cardNumber;
            Name = name;
        }
        public void Present()
        {
            Console.WriteLine($"Game: {GameTitle}");
            Console.WriteLine($"Card number: {CardNumber}");
            Console.WriteLine($"Is rare: {IsRare}");
            Console.WriteLine($"Card name: {Name}");
            Console.WriteLine($" ");
        }

        public void Play()
        {
            Console.WriteLine($"Card nr: {CardNumber} got played!");
            Console.WriteLine($" ");
        }
    }
}
