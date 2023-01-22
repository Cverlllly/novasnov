using System;

public class Class1
{
	public double price { get; set; }
    public static double tax { get; set; }
    public double GetBrutoPrice()
    {
        return price + (price * tax);
    }
    public static double sum(double a, double b)
    {
        return a + b;
    }  
    public static void IncreaseValue()
    {
        tax = tax + 0.5;
    }
}
