///<summary>
///     Validation Interface
///     Validate number is even or not, number is lessthan 10 or not and number is divisibe by five or not.
///</summary>
namespace CustomValidation
{
    interface IValidation
    {
        bool CheckEven(int number);
        bool CheckLessThanTen(int number);
        bool CheckDivisibleByFive(int number);
    }
}