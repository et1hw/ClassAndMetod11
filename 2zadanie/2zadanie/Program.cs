using System;

class User
{
    
    public string FullName { get; set; }

   
    public string Username { get; set; }

  
    private string Password { get; set; }

    //  роль пользователя 
    public string Role { get; set; }

    // дата последнего входа 
    public DateTime LastLogin { get; set; }

    // Свойство  доступ к складу 
    public bool HasWarehouseAccess { get; set; }

    
    public User(string fullName, string username, string password, string role, DateTime lastLogin, bool hasWarehouseAccess)
    {
        FullName = fullName;
        Username = username;
        Password = password; 
        Role = role;
        LastLogin = lastLogin;
        HasWarehouseAccess = hasWarehouseAccess;
    }

    // Метод для отображения информации о пользователе
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {FullName}");
        Console.WriteLine($"Логин: {Username}");
        Console.WriteLine($"Роль: {Role}");
        Console.WriteLine($"Дата последнего входа: {LastLogin.ToShortDateString()}");
        Console.WriteLine($"Доступ к складу: {(HasWarehouseAccess ? "Есть" : "Нет")}");
    }

    // Метод для проверки пароля
    public bool CheckPassword(string inputPassword)
    {
        return inputPassword == Password;
    }
}

class Program
{
    static void Main()
    {
        // Создание нового пользователя
        User user1 = new User("Марков Глеб", "gleb", "qwerty123", "Админ", DateTime.Now.AddDays(-10), true);

        // Ввод логина и пароля для авторизации
        Console.WriteLine("Введите логин:");
        string enteredUsername = Console.ReadLine();

        Console.WriteLine("Введите пароль:");
        string enteredPassword = Console.ReadLine();

        // Авторизация
        if (Authenticate(user1, enteredUsername, enteredPassword))
        {
            // Если авторизация успешна
            Console.WriteLine("Авторизация успешна! Информация о пользователе:");
            user1.DisplayInfo();
        }
        else
        {
            // Если логин или пароль неверные
            Console.WriteLine("Неверный логин или пароль.");
        }
    }

    // Метод для авторизации пользователя
    static bool Authenticate(User user, string username, string password)
    {
        // Проверяем, совпадает ли логин и пароль
        if (user.Username == username && user.CheckPassword(password))
        {
            return true; //  успешно
        }
        return false; // Логин или пароль неверные
    }
}
