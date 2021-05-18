using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_01_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("   ***Task Manager***   ");
            #region   Test

            ////  завершает процесс в экстренном режиме
            //Process notepad = Process.Start("notepad.exe");
            //Console.WriteLine("Нажмите любую клавишу для завершения процесса...");
            //Console.ReadKey();
            //notepad.Kill();
            //Console.WriteLine(notepad.ExitCode); // -1

            //// завершает процесса в штатном режиме
            //Process notepad2 = Process.Start("notepad.exe");
            //Console.WriteLine("Для продолжения, закройте окно Блокнота...");
            //notepad2.WaitForExit();
            //Console.WriteLine(notepad2.ExitCode); // 0

            #endregion

            Process[] processes = Process.GetProcesses();

            Console.WriteLine("   Старт процесса    |  Id процесса   | Имя процесса");
            foreach (var i in processes)
            {
                try
                {
                   Console.WriteLine($"{i.StartTime}     {i.Id}          {i.ProcessName}") ;
                }
                catch 
                {
                    Console.WriteLine($"                       {i.Id}          {i.ProcessName}");

                }   
         
            };
            int enterInt = 3;
            int enterIdInt = 0;
            do
            {
                Console.WriteLine("Если Вы нажмёте на: ");
                Console.WriteLine("                   '0' и Ввод, то Вы выйдите из программы");
                Console.WriteLine("                   '1' и Ввод, то Вы сможете закрыть процесс по Id процесса");
                Console.WriteLine("                   '2' и Ввод, то Вы сможете закрыть процесс по Имени процесса");

                try
                {
                    string enter = Console.ReadLine();

                     enterInt = Convert.ToInt32( enter);
                }
                catch (Exception)
                { 
                }

            } while (!(enterInt == 0 || enterInt == 1|| enterInt == 2));

            if (enterInt == 1)
            {
                Console.WriteLine("Выберите Id процесс для закрытия: ");

                try
                {
                    string enterId = Console.ReadLine();

                    enterIdInt = Convert.ToInt32(enterId);

                    foreach (var i in processes)
                    {
                        if (enterIdInt == i.Id)
                        {
                            i.Kill();
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
            else if (enterInt == 2)
            {
                Console.WriteLine("Выберите Именя процесс для закрытия: ");

                try
                {
                    string enterName = Console.ReadLine();
                    foreach (var i in processes)
                    {
                        if (enterName == i.ProcessName)
                        {
                            i.Kill();
                        }
                    }
                }
                catch (Exception)
                {
                }
            }









        }
    }
}
