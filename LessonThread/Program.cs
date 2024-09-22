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
    
    static void WakeupAndSleep()
    {
        Console.WriteLine("Просыпается и лежит в кровати");
        Thread.Sleep(1500);
    }
    
    static void PutsTheKettle()
    {
        Task task2 = Task.Run(() =>
        {
            Console.WriteLine("Ставит чайник на плиту");
            Task.Delay(500);
        });
    }
    
    static void Reheatsdinner()
    {
        Task task3 = Task.Run(() =>
        {
            Console.WriteLine("Подогревает вчерашний ужин");
            Task.Delay(500);
        });
    }
    
    static void TakingAbath()
    {
        Task task4 = Task.Run(() =>
        {
            Console.WriteLine("Набирает ванну");
            Task.Delay(1000);
        });
    }
    
    static void SwimABath()
    { 
        Console.WriteLine("Принимает ванну");
        Thread.Sleep(1500);
    }
    
    static void HavingBreakfast()
    {
        Task task5 = Task.Run(() =>
        {
            Console.WriteLine("Завтракает");
            Task.Delay(1000);
        });
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