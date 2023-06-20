namespace Library
{
    public class Singleton<S> where S : new()
    {
        private static S instance;
        public static S Instance
        {
            get
            {

             if (instance == null)
                {
                    instance = new S();
                }
                return instance;
            }
        }
    }
}