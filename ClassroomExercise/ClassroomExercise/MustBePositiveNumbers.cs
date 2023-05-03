namespace ClassroomExercise
{
    internal class MustBePositiveNumbers : Checker
    {
        public override (bool, string) ProcessRequest(UserInput userInput)
        {
            if (int.Parse(userInput.GetFirstPart) > 0 && int.Parse(userInput.GetSecondPart) > 0)
            { 
                if (_successor != null)
                    return _successor.ProcessRequest(userInput);
                return (true, "Input string contain two positive numbers");
            }
            return (false, "Input string DOES NOT have two positive numbers");
        }
    }
}
