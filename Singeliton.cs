namespace Exp
{
    public class SingleTon : test.FirstInterface, test.FirstInterface2
    {
        private static SingleTon? _instance;

        SingleTon(){
        }

        public static SingleTon getInstance(){
            if (_instance == null)
            {
            _instance = new SingleTon();
            }
            return _instance;
        }


    }
    
}