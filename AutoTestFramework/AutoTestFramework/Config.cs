namespace FirstLesson
{
    public static class Config
    {
        public static string BasicURL = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "asdf";
                    public static string ThirteenCharacters = "asdfasdfasdfasdfG";
                }

                public static class Password
                {
                    public static string InvalidPassword = "dfgdfgd";
                }

                public static class Email
                {

                }
            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
            public static string InvalidUsername = "User Id should not be empty / length be between 5 to 12";
            public static string InvalidPassword = "Password should not be empty / length be between 5 to 12zxcz";
            public static string PasswordDoNotMatch = "Passwords do not match!";
        }

    }
}
