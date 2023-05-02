namespace ClassroomExercise
{
    internal class MustBeTwoNumbers : Checker
    {
        public override (bool, string) ProcessRequest(UserInput userInput)
        {
            if (int.TryParse(userInput.GetFirstPart, out _) && int.TryParse(userInput.GetSecondPart, out _))
                return _successor.ProcessRequest(userInput);
            return (false, "Input string DOES NOT have two numbers");
        }
    }
}
