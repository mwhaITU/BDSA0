public class IsLeapYear
{
   public bool IntIsLeapYear(int year) 
   {
        if(year < 1582) 
        {
            return false;
        }
        try {
            if(DateTime.IsLeapYear(year)) {
                return true;
            }
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        return false;
   }
}