namespace Exp
{
    public class SingleTon{
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