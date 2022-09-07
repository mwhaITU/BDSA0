public class IsLeapYear
{
   public bool IntIsLeapYear(int year) 
   {
        if(year < 1582) 
        {
            return false;
        }
        try {
            if(year%400 == 0) {
                return true;
            }
            if(year%100 == 0) {
                return false;
            }
            if(year%4 == 0) {
                return true;
            }
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        return false;
   }
}