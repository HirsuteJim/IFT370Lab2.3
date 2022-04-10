class Program {
    static void Main(string[] args)   {
        Singleton mySingleton = Singleton.Instance;
        Console.WriteLine("\n\n================================================================================");
        Console.WriteLine(mySingleton.GetThree());
        Console.WriteLine("\n\n================================================================================");

    }
}