

namespace NonThreadSafe_Singleton 
{ 
    public sealed class Database
    {
        private static readonly Database? _instance = null;
        private Database()
        {

        }

        public static Database GetInstance()
        {
            if (_instance == null) return new Database();
            return _instance;
        }

        public void Query(string sql)
        {
            Console.WriteLine(sql + " returned");
        }
    }
}

