using System;
using System.Diagnostics;
namespace Home_Task_6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас я выведу Вам на экран Список всех запущенных процессов!\nВ этом списке будет указаны имя процесса Name и его ID номер!");
            Console.ReadLine();
            Process[] launchProcess = Process.GetProcesses();
            foreach(Process process in Process.GetProcesses())
            
                Console.WriteLine($"ID: {process.Id}\t Name: {process.ProcessName}\t");
            
            Console.WriteLine("Введите ID номер процесса или его имя для его закрытия");

            string UserInput = Console.ReadLine();
            
            for (int i = 0; i < launchProcess.Length; i++)
            {
                if (UserInput == Convert.ToString(launchProcess[i].Id) || UserInput == launchProcess[i].ProcessName)
                {
                    launchProcess[i].Kill();
                    Console.WriteLine($"Процесс {UserInput} выгружен из памяти");
                }
                
            }
            Console.WriteLine("Введенному Вами значению не соответствует ни один процесс!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
