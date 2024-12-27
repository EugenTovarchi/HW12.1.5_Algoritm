public class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }

    public static void CheckIsPremium(List<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"Приветствуем тебя {user.Name}");
            if (user!.IsPremium)
            {
                ShowAds();
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new User{Login = "petrovich", Name = "Petr", IsPremium = false},
            new User{Login = "vasillich", Name = "Vasya", IsPremium=false},
            new User{Login = "major", Name = "Adonis", IsPremium = true}
        };

        User.CheckIsPremium(users);
    }
}