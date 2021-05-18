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

            Console.WriteLine("  Id процесса   | Имя процесса");
            foreach (var i in processes)
            {
                Console.WriteLine($"  {i.Id}          {i.ProcessName}") ;

            };




        }
    }
}
