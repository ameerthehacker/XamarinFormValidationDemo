using XamarinFormValidation.Validators.Contracts;

namespace XamarinFormValidation.Validators.Implementations
{
    public class RequiredValidator: IValidator
    {
        public string Message { get; set; } = "This field is required";

        public bool Check(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
