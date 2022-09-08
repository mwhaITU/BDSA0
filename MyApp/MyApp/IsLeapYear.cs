public class IsLeapYear
{
   public bool IntIsLeapYear(int year) 
   {
        if(year < 1582) 
        {
            return false;
        }
        try {
            if(year%4 != 0) {
                return false;
            }
            else if(year%100 != 0) {
                return true;
            }
            else if(year%400 != 0) {
                return false;
            }
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        return true;
   }
}