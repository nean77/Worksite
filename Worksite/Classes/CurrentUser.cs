namespace Worksite.Classes
{
    public class CurrentUser
    {
        private long _userId;
        private string _firstName;
        private string _lastName;
        private bool _administrator;
        private static CurrentUser _instance;

        private CurrentUser() { }

        public void SetCurUser(long userId, string firstName, string lastName, bool administrator)
        {
            _userId = userId;
            _firstName = firstName;
            _lastName = lastName;
            _administrator = administrator;
        }
        

        public long UserId { get => _userId; set => _userId = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public bool Administrator { get => _administrator; set => _administrator = value; }
        public static CurrentUser GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CurrentUser();
            }
            return _instance;
        }
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
