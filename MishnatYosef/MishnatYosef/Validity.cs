using System.Text.RegularExpressions;
namespace MishnatYosef
{
    public class Validity<T>
    {
        public bool IsValidIsraeliIdentityNumber(string identityNumber)
        {
            if (string.IsNullOrEmpty(identityNumber) || identityNumber.Length != 9)
                return false; 
            int[] factors = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            { 
                int digit = int.Parse(identityNumber[i].ToString());
                int product = digit * factors[i]; sum += (product > 9) ? product - 9 : product; 
            }
            return sum % 10 == 0;
        }
         public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern); 
        }
}
}
