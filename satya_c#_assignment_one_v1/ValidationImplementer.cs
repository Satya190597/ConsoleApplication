class ValidationImplementer : IValidation
{
    public bool CheckEven(int number)
    {
        return (number%2==0)? true : false;
    }
    public bool CheckLessThanTen(int number)
    {
        return (number>10) ? true : false;
    }
    public bool CheckDivisibleByFive(int number)
    {
        return (number%5==0) ? true : false;
    }
}