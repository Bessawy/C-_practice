namespace test{
    public enum Color{
        Yellow,
        Blue,
        Red,
        Green
    }

    public enum Position{
        Top = 1 << 0,
        Left = 1 << 1,
        Right = 1 << 2,
        Bottom = 1 << 3
    }
    public struct myStruct{
    int x = 0;
    string y = "";
   
    public myStruct(int x, string y){
        this.x = x;
        this.y = y;
    }
    
    public void print() => Console.WriteLine($"{this.y} is equal to {this.x}");
}

}