public class Program {
    static void Main(string[] args) 
    {
        IsLeapYear isLeapYear = new IsLeapYear();
        int year = Convert.ToInt32(Console.ReadLine());
        if(isLeapYear.IntIsLeapYear(year)) {
            Console.WriteLine("Yay");
        } else 
        { 
            Console.WriteLine("Nay");
        } 
    }
}
