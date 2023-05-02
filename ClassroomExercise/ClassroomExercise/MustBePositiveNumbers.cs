namespace ClassroomExercise
{
    internal class MustBePositiveNumbers : Checker
    {
        public override (bool, string) ProcessRequest(UserInput userInput)
        {
            if (int.Parse(userInput.GetFirstPart)> 0 && int.Parse(userInput.GetSecondPart) > 0)
                return _successor.ProcessRequest(userInput);
            return (false, "Input string DOES NOT have two positive numbers");
        }
    }
}
