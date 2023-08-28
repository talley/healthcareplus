using System.ComponentModel.DataAnnotations;

namespace HCP.Helpers
{
    public static class EmailHelper
    {
        public static bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
    }
}
