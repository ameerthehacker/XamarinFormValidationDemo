using System.Text.RegularExpressions;
using XamarinFormValidation.Validators.Contracts;

namespace XamarinFormValidation.Validators.Implementations
{
    public class FormatValidator: IValidator
    {
        public string Message { get; set; } = "Invalid format";
        public string Format { get; set; }

        public bool Check(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Regex format = new Regex(Format);

                return format.IsMatch(value);
            }
            else
            {
                return false;
            }
        }
    }
}
