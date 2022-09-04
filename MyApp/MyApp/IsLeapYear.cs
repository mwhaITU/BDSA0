public class IsLeapYear
{
   public bool IntIsLeapYear(int year) 
   {
        if(DateTime.IsLeapYear(year)) {
            return true;
        }
        return false;
   }
}