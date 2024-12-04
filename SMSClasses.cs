
namespace StudentManagementSystem
{
    class User
    {
        public string userID {get; protected set};
        public string username { get; protected set};
        public string password { get; protected set};
        public string role { get; protected set};
        bool Login()
        {
            return false;
        }
        void Logout()
        {
            return;
        }
        bool isAuthorized() { 
            return false; 
        }
    }
    class Admin : User
    {
        public int adminID { get; protected set};
        void addUser()
        {
            return;
        }
        void deleteUser()
        {
            return;
        }
    }
}
