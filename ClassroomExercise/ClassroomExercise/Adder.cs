namespace ClassroomExercise
{
    internal class Adder : Checker
    {
        public override (bool, string) ProcessRequest(UserInput userInput)
        {
            return (true, $"The sum of the two number is: {int.Parse(userInput.GetFirstPart) + int.Parse(userInput.GetSecondPart)}");
        }
        //classe a parte
    }
}
