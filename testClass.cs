namespace Exp
{
    public class Human{
        int _age = 22;
        public const string discript = "hello";
        int[] arr = new int[10];
        public int health {get; init;}
        public int meter {get; private set;}
        public int age {
            get=> _age;
             set{
                if(value < 10){
                    Console.WriteLine("Age cannot be change");
                }
                else{
                    _age = value;
                }
             }}
        public string name {get; set;}

        public Human(int age, string name){
            this.age = age;
            this.name = name;
        }

        public int this[Index index]{
            get=> arr[index];
            set=> arr[index] = value;
        }

        public int[] this[Range range]{
            get=> arr[range];
        }
        

        public Human(): this(0, String.Empty){
        }

        public string print(){
            return $"Age of {name} is {age}";
        }

        public void Deconstruct(out string name, out int age){
            name = this.name;
            age = this.age;
        }

        
    }
}