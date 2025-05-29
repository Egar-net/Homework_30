namespace ConsoleApp3
{
    public delegate string WorkStr();
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Lamp lamp = new Lamp();
            Man man = new Man();

            WorkStr s = cat.WhatIsDoingNow;
            s += lamp.GetLampStatus;
            s += man.WhatHeIsDoingNow;

            for (int i = 0; i < s.GetInvocationList().Length; i++)
            {
                Console.WriteLine($"{i + 1}. {s.GetInvocationList()[i].DynamicInvoke()}");
            }
        }
    }
}
