using NonThreadSafe.Singleton;

class Program
{
    public static void Main(string[] args)
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();
        Singleton s3 = Singleton.GetInstance();
        if (s1 == s2) Console.WriteLine("The instances are the same!");

        Database db = Database.GetInstance();
        db.Query("Mark");


    }
}
