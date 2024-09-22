using System.Diagnostics;
using System.Threading.Channels;

namespace LessonThread;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Сотрудник Вася просыпается в 07:30"); 
        Stopwatch timer = new Stopwatch();
        timer.Start();    // Ожидание потока Васи
        await LifeVasya();
        timer.Stop();   // Остоновка таймера
        Console.WriteLine("Сотрудник Вася на работе");
        Console.WriteLine($"Времени потрачено: {timer.ElapsedMilliseconds / 100} минут");
    }
    
    static async Task LifeVasya()
    {
        await WakeupAndSleep();
        Task t2 = PutsTheKettle();
        Task t3 = Reheatsdinner();
        Task t4 = TakingAbath();
        await Task.WhenAll(t2, t3, t4);
        await SwimABath();
        await HavingBreakfast();
        await GettingDressed();
        await GoingToWork();
    }
    
    static async Task WakeupAndSleep()
    {
        Console.WriteLine("Просыпается и лежит в кровати");
        await Task.Delay(1500);
    }
    
    static async Task PutsTheKettle()
    {
        Console.WriteLine("Ставит чайник на плиту"); 
        await Task.Delay(500);
    }
    
    static async Task Reheatsdinner()
    {
        Console.WriteLine("Подогревает вчерашний ужин");
        await Task.Delay(500);
    }
    
    static async Task TakingAbath()
    {
        Console.WriteLine("Набирает ванну");
        await Task.Delay(1000);
    }
    
    static async Task SwimABath()
    { 
        Console.WriteLine("Принимает ванну");
        await Task.Delay(1500);
    }
    
    static async Task HavingBreakfast()
    {
        Console.WriteLine("Завтракает");
        await Task.Delay(1000);
    }
    static async Task GettingDressed()
    {
        Console.WriteLine("Одевается");
        await Task.Delay(500);
    }
    static async Task GoingToWork()
    {
        Console.WriteLine("Едет на работу");
        await Task.Delay(5500);
    }
}