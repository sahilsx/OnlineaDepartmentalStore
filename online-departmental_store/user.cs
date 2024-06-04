namespace online_departmental_store
{
     class user
    {
        string username;
        string password;

        public user(string username, string password)
        {
            this.username = username;
            this.password = password;

        }
             public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

    }

}