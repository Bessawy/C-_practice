public class OverRideMe{
    public override bool Equals(object obj){
        return true;
    }

    public override int GetHashCode()
    {
        HashCode.Combine(2, 2, 3);
        return base.GetHashCode();
    }
    
    public static bool operator == (OverRideMe r1, OverRideMe r2){
        return true;
    }

    public static bool operator != (OverRideMe r1, OverRideMe r2){
        return true;
    }

    
}