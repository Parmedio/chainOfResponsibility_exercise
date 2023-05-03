namespace ClassroomExercise
{
    internal class MustBeTwoNumbers : Checker
    {
        public override (bool, string) ProcessRequest(UserInput userInput)
        {
            if (int.TryParse(userInput.GetFirstPart, out _) && int.TryParse(userInput.GetSecondPart, out _))
            {
                if (_successor != null)
                    return _successor.ProcessRequest(userInput);
                return (true, string.Empty);
            }
            return (false, "Input string DOES NOT have two numbers");
        }
    }
}
