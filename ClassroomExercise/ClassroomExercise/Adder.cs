namespace ClassroomExercise
{
    public static class Adder
    {
        public static (bool, string) doSum(UserInput userInput)
        {
            return (true, $"The sum of the two number is: {int.Parse(userInput.GetFirstPart) + int.Parse(userInput.GetSecondPart)}");
        }
    }
}
