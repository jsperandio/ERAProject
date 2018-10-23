namespace ERAProject.Model.System
{
    sealed class Session
    {
        private static Session instance = null;
        private static readonly object lockObject = new object();

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }
        }

        public Session()
        {
        }


    }
}
