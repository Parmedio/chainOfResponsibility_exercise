namespace ClassroomExercise
{
    public class SetupChain
    {
        private readonly Checker _chain;
        public SetupChain()
        {
            var mustBeTwoNumbers = new MustBeTwoNumbers();
            var mustBePositiveNumbers = new MustBePositiveNumbers();
            var adder = new Adder();

            mustBeTwoNumbers.SetSuccessor(mustBePositiveNumbers);
            mustBePositiveNumbers.SetSuccessor(adder);
            _chain = mustBeTwoNumbers;
        }
        public Checker GetChain => _chain;
    }
}
