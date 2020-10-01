using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using DynamicFr;
using System.Windows.Forms;
using System.Net.WebSockets;


namespace Hwid
{
    class Program
    {
        public static object Clipboard { get; private set; }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("██╗░░░██╗██╗██╗░░██╗██╗░░░██╗░██╗░░█████╗░░█████╗░░█████╗░░░███╗░░");
            Console.WriteLine("██║░░░██║██║██║░██╔╝██║██████████╗██╔══██╗██╔══██╗██╔══██╗░████║░░");
            Console.WriteLine("╚██╗░██╔╝██║█████═╝░██║╚═██╔═██╔═╝██║░░██║██║░░██║██║░░██║██╔██║░░");
            Console.WriteLine("░╚████╔╝░██║██╔═██╗░██║██████████╗██║░░██║██║░░██║██║░░██║╚═╝██║░░");
            Console.WriteLine("░░╚██╔╝░░██║██║░╚██╗██║╚██╔═██╔══╝╚█████╔╝╚█████╔╝╚█████╔╝███████╗");
            Console.WriteLine("░░░╚═╝░░░╚═╝╚═╝░░╚═╝╚═╝░╚═╝░╚═╝░░░░╚════╝░░╚════╝░░╚════╝░╚══════╝");
            Console.ResetColor();

            Console.Title = " V1.0 | Hwid checker by viki#0001 | https://discord.gg/DqTzMeC ";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please wait...");
            Console.ResetColor();
            Thread.Sleep(500);
            string Ucheck = "v1.0";

            WebClient webClient = new WebClient();
            string a = webClient.DownloadString("https://pastebin.com/raw/Z3Qjc6u5");
            bool flag = a == $"{Ucheck}";
            if (flag)
            {
                string identifierC1 = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Your current hwid is");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($" >> ");
                //Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ResetColor();
                Console.Write($"{identifierC1}");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
               
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("███████╗██████╗░██████╗░░█████╗░██████╗░  ░░██╗██╗░█████╗░░░██╗██╗");
                Console.WriteLine("██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ░██╔╝██║██╔══██╗░██╔╝██║");
                Console.WriteLine("█████╗░░██████╔╝██████╔╝██║░░██║██████╔╝  ██╔╝░██║██║░░██║██╔╝░██║");
                Console.WriteLine("██╔══╝░░██╔══██╗██╔══██╗██║░░██║██╔══██╗  ███████║██║░░██║███████║");
                Console.WriteLine("███████╗██║░░██║██║░░██║╚█████╔╝██║░░██║  ╚════██║╚█████╔╝╚════██║");
                Console.WriteLine("╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝  ░░░░░╚═╝░╚════╝░░░░░░╚═╝");
                //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
                Console.WriteLine("Project either disabled or a new verison is out!");
                Console.WriteLine("Contact viki#0001 or https://discord.gg/DqTzMeC");
                Console.ReadKey();
                Console.ResetColor();
            }
        }
    }
}
