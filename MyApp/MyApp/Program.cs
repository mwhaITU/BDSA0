public class Program {
    static void Main(string[] args) 
    {
        IsLeapYear isLeapYear = new IsLeapYear();
        int year = 0;
        try {
            year = Convert.ToInt32(Console.ReadLine());
        } catch(Exception e) {
            Console.WriteLine(e.Message);
            return;
        }
        if(isLeapYear.IntIsLeapYear(year)) {
            Console.WriteLine("Yay");
        } else { 
            Console.WriteLine("Nay");
        } 
    }
}
