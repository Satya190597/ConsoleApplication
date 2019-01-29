///<summary>
///     Custom Input Interface
///     Conatins menu driven user input options.
///</summary>
namespace CustomInput
{
    interface ICustomInput
    {
        int[] GetUserNumbers(int size);
        int GetUserChoiceToFilter();
        int GetUserChoiceToContinue();
    }
}