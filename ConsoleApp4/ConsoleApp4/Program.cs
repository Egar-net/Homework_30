namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new MessageManager();
            var phone = new Phone(manager);
            var mail = new Mail(manager);

            Console.WriteLine("Sending massage");
            Console.Write("Enter type message: ");
            string type = Console.ReadLine();

            Console.Write("Enter massage: ");
            string text = Console.ReadLine();

            manager.SendMessage(new MyMessage(type, text));
        }
    }
}
