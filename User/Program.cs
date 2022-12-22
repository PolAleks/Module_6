namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Email = "Test@ya.ru";
            Console.WriteLine(user.Email);
            user.Login = "Jon";
            Console.WriteLine(user.Login);
        }
    }
    class User
    {
        private int age;
        private string login;
        private string email;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен содержать более 3 символов.");
                }
                else
                {
                    login = value;
                }
            }
        }
        public string Email
        {
            get 
            { 
                return email; 
            }
            set
            {
                bool isCorrect = value.Contains('@');
                if (isCorrect) 
                {
                    email = value;
                }
                else 
                {
                    Console.WriteLine("Вы ввели некорректный email адрес");
                }
            }
        }
    }
}