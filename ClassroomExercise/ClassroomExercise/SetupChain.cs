namespace ClassroomExercise
{
    public class SetupChain
    {
        private readonly Checker _chain;
        public SetupChain()
        {
            var mustBeTwoNumbers = new MustBeTwoNumbers();
            var mustBePositiveNumbers = new MustBePositiveNumbers();

            mustBeTwoNumbers.SetSuccessor(mustBePositiveNumbers);
            _chain = mustBeTwoNumbers;
        }
        public Checker GetChain => _chain;
    }
}
