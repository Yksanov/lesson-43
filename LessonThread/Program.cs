using System.Diagnostics;
using System.Threading.Channels;

namespace LessonThread;

class Program
{
    static void Main(string[] args)
    {
        Thread th = new Thread(LifeVasya);
        Console.WriteLine("Сотрудник Вася просыпается в 07:30"); 
        Stopwatch timer = new Stopwatch();
        timer.Start();
        th.Start();       // Запуск потока
        th.Join();       // Ожидание потока Васи
        timer.Stop();   // Остоновка таймера
        Console.WriteLine("Сотрудник Вася на работе");
        Console.WriteLine($"Времени потрачено: {timer.ElapsedMilliseconds / 100} минут");
    }
    
    static void LifeVasya()
    {
        WakeupAndSleep();
        PutsTheKettle();
        Reheatsdinner();
        TakingAbath();
        SwimABath();
        HavingBreakfast();
        GettingDressed();
        GoingToWork();
    }
    
    static void  WakeupAndSleep()
    {
        Console.WriteLine("Просыпается и лежит в кровати");
        Thread.Sleep(1500);
    }
    
    static void PutsTheKettle()
    {
        Console.WriteLine("Ставит чайник на плиту");
        Thread.Sleep(500);
    }
    
    static void Reheatsdinner()
    {
        Console.WriteLine("Подогревает вчерашний ужин");
        Thread.Sleep(500);
    }
    
    static void TakingAbath()
    {
        Console.WriteLine("Набирает ванну");
        Thread.Sleep(1000);
    }
    
    static void SwimABath()
    { 
        Console.WriteLine("Принимает ванну");
        Thread.Sleep(1500);
    }
    
    static void HavingBreakfast()
    {
        Console.WriteLine("Завтракает"); 
        Thread.Sleep(1000);
    }
    static void GettingDressed()
    {
        Console.WriteLine("Одевается");
        Thread.Sleep(500);
    }
    static void GoingToWork()
    {
        Console.WriteLine("Едет на работу");
        Thread.Sleep(5500);
    }
}