using NonThreadSafe_Singleton;

class Program
{
    public static void Main(string[] args)
    {
        SingletonClass s1 = SingletonClass.GetInstance();
        s1.SomeBussinessLogic();
        SingletonClass s2 = SingletonClass.GetInstance();
        s2.SomeBussinessLogic();
        SingletonClass s3 = SingletonClass.GetInstance();
        s3.SomeBussinessLogic();
        if (s1 == s2) Console.WriteLine("The instances are the same!");

        Database db = Database.GetInstance();
        db.Query("Mark");


    }
}
