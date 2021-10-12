using System;
interface ICustomer1
{
    void Print1();
}
interface ICustomer2 : ICustomer1
{
    void Print2();
}
public class Customer : ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("Print1 Method of ICustomer1");
    }
    public void Print2()
    {
        Console.WriteLine("Print2 Method of ICustomer2");
    }
}
class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print1();
        C1.Print2();

        ICustomer1 C2 = new Customer();
        C2.Print1();

        Console.ReadKey();

    }
}