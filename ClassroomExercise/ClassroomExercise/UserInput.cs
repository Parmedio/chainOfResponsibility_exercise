namespace ClassroomExercise
{
    public class UserInput
    {
        private readonly string _userString;

        public string GetFirstPart => GetParts(_userString, 0);
        public string GetSecondPart => GetParts(_userString, 1);

        public UserInput(string input)
        {
            _userString = input;
        }

        public string GetParts(string input, int number)
        {
            string[] parts = input.Split(',');
            return parts[number];
        }

        public string GetNumbers() => $"The first part of the string is \"{GetFirstPart}\" and the second is \"{GetSecondPart}\"";
        public string GetUserString() => $"This is the string given by the user: \"{_userString}\"";
    }
}
