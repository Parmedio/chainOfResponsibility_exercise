namespace ClassroomExercise
{
    public class UserInput
    {
        private readonly string _userString;

        public string GetFirstPart { get; set; }
        public string GetSecondPart { get; set; }

        public UserInput(string input)
        {
            _userString = input;
        }

        public void GetParts()
        {
            string[] parts = _userString.Split(',');
            if (parts.Length != 2)
                throw new Exception("string length illegal");
            GetFirstPart = parts[0];
            GetSecondPart = parts[1];
        }
        
        public string GetNumbers() => $"The first part of the string is \"{GetFirstPart}\" and the second is \"{GetSecondPart}\"";
        public string GetUserString() => $"This is the string given by the user: \"{_userString}\"";
    }
}
