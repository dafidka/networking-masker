using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace networking
{


    class Program
    {
        static string ToBinary(int n)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (n > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (n & mask) + binary;
                n = n >> 1;
            }

            binary = binary.PadLeft(8, '0');
            return binary;
        }


        static void Main(string[] args)
        {
        start:
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Betöltés...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.Write(" / ");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(" ─ ");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(@" \ ");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(" |");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(" /");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(" ─ ");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(@" \ ");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            Console.Write(" |");
            System.Threading.Thread.Sleep(30);
            Console.Clear();
            System.Threading.Thread.Sleep(30);
            Console.ForegroundColor = ConsoleColor.Black;
            string s = "-----Masker by Dafid-----";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);


            Console.ForegroundColor = ConsoleColor.White;
            string ip;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Add meg az IP címet (a.b.c.d/e), vagy írd be, hogy help");
        ip:
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            ip = Console.ReadLine();
            
            switch (ip)
            {
                case "exit":
                    Environment.Exit(0);
                    break;
                case "esc":
                    Environment.Exit(0);
                    break;
                case "kilep":
                    Environment.Exit(0);
                    break;
                case "ki":
                    Environment.Exit(0);
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
                case "again":
                    Console.Clear();
                    goto start;
                case "start":
                    Console.Clear();
                    goto start;
                case "restart":
                    Console.Clear();
                    goto start;
                case "r":
                    Console.Clear();
                    goto start;
                case "s":
                    Console.Clear();
                    goto start;
                case "ver":
                    Console.WriteLine("Version: 1.0");
                    goto ip;
                case "version":
                    Console.WriteLine("Version: 1.0");
                    goto ip;
                case "v":
                    Console.WriteLine("Version: 1.0");
                    goto ip;
                case "":
                    Console.Clear();
                    Console.WriteLine("exit     -> kilép a programból");
                    Console.WriteLine("start    -> a program elejére dob");
                    Console.WriteLine("version  -> kiírja a program verziószámát");
                    Console.WriteLine("help     -> kiírja ezt az üzenetet");
                    goto ip;
                case "help":
                    Console.Clear();
                    Console.WriteLine("exit     -> kilép a programból");
                    Console.WriteLine("start    -> a program elejére dob");
                    Console.WriteLine("version  -> kiírja a program verziószámát");
                    Console.WriteLine("help     -> kiírja ezt az üzenetet");
                    goto ip;

            }
            Console.ForegroundColor = ConsoleColor.White;
            string[] number = ip.Split('.', '/');
            try
            {
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(s);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(number[0] + "." + number[1] + "." + number[2] + "." + number[3] + "/" + number[4]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" \t\t   <== A megadott IP cím \n");
                Console.ForegroundColor = ConsoleColor.White;
                goto noException;
            }
            catch (IndexOutOfRangeException)
            {
                goto foundException;
            }

        foundException:

            try
            {
                Console.WriteLine(number[0] + "." + number[1] + "." + number[2] + "." + number[3] + "     <== A megadott IP cím");
            }
            catch (Exception)
            {
                //Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Hibába ütköztem :/ ");
                System.Threading.Thread.Sleep(1000);
                goto start;

            }
            

        noException:

            int szam1;
            int szam2;
            int szam3;
            int szam4;
            szam1 = Convert.ToInt32(number[0]);
            szam2 = Convert.ToInt32(number[1]);
            szam3 = Convert.ToInt32(number[2]);
            szam4 = Convert.ToInt32(number[3]);
            Console.WriteLine(ToBinary(szam1) + "-" + ToBinary(szam2) + "-" + ToBinary(szam3) + "-" + ToBinary(szam4)+"   <== A megadott IP cím binárisan");
            string hex1 = szam1.ToString("X2");
            string hex2 = szam2.ToString("X2");
            string hex3 = szam3.ToString("X2");
            string hex4 = szam4.ToString("X2");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(hex1 + "-" + hex2 + "-" + hex3 + "-" + hex4+"");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   \t\t\t <== A megadott IP cím HEX - ben\n");

            int maskNumber = default;
                try
                {
                maskNumber = Convert.ToInt32(number[4]);
                goto noException2;
                }
                catch (IndexOutOfRangeException)
                {
                    goto Exception2;
                }
            

        Exception2:
            maskNumber = default;
            Console.Clear();
            Console.WriteLine("Hibába ütköztem, lehet nem adtál meg net bitet? :/ (IP/24-30)");
            System.Threading.Thread.Sleep(1000);
            goto start;

        noException2:
            string mask;
            string decmask;
            switch (maskNumber)
            {
                case 24:
                    mask = "11111111111111111111111100000000";
                    decmask = "255.255.255.0";
                    break;
                case 25:
                    mask = "11111111111111111111111110000000";
                    decmask = "255.255.255.128";
                    break;
                case 26:
                    mask = "11111111111111111111111111000000";
                    decmask = "255.255.255.192";
                    break;
                case 27:
                    mask = "11111111111111111111111111100000";
                    decmask = "255.255.255.224";
                    break;
                case 28:
                    mask = "11111111111111111111111111110000";
                    decmask = "255.255.255.240";
                    break;
                case 29:
                    mask = "11111111111111111111111111111000";
                    decmask = "255.255.255.248";
                    break;
                case 30:
                    mask = "11111111111111111111111111111100";
                    decmask = "255.255.255.252";
                    break;
                case 31:
                    mask = "11111111111111111111111111111110";
                    decmask = "255.255.255.254";
                    break;
                case 32:
                    mask = "11111111111111111111111111111111";
                    decmask = "255.255.255.255";
                    break;
                default:
                    try
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.Clear();
                        Console.WriteLine("Hibába ütköztem, viszont ötletem sincs mi lehet az :/");
                        System.Threading.Thread.Sleep(1000);
                        goto start;
                    }

            }
            
            Console.WriteLine(ToBinary(szam1) + ToBinary(szam2) + ToBinary(szam3) + ToBinary(szam4)+"      <== Bináris IP");
            Console.WriteLine("|       |       |       |       |");
            Console.WriteLine(mask+"      <== Bináris netmask");
            Console.WriteLine("|       |       |       |       |");
            string sorEgy = ToBinary(szam1) + ToBinary(szam2) + ToBinary(szam3) + ToBinary(szam4);
            string sorKetto = mask;
            int i;
            string binNetAddress = null;

            for (i = 0; i < sorEgy.Length; i++)
            {
                if (sorEgy[i] == '1' && sorKetto[i] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1");
                    Console.ForegroundColor = ConsoleColor.White;
                    binNetAddress += '1';
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("0");
                    Console.ForegroundColor = ConsoleColor.White;
                    binNetAddress += '0';
                }

            }
            //Regex.Split(binNetAddress, "(?<=^(.{8})+)");
            var res = String.Join(",", Regex.Matches(binNetAddress, @"\d{8}").Cast<Match>());
            string[] arrBin = res.Split(',');
            
            int dec1 = Convert.ToInt32(arrBin[0],2);
            int dec2 = Convert.ToInt32(arrBin[1],2);
            int dec3 = Convert.ToInt32(arrBin[2],2);
            int dec4 = Convert.ToInt32(arrBin[3],2);
            

            Console.Write("      <== Bináris Hálózati azonosító\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(decmask+"");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("         <== Decimális netmask\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(dec1+"."+dec2+"."+dec3+"."+dec4);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("      <== Decimális Hálózati azonosító");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            string answer = null;
            Console.WriteLine("*\n*\n*\n*\n*\n*\n*\n*\n*\n*\n*\n*\n*");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("help -->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  megmutatja a többi lehetöséget\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("exit -->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  bezárja a programot\n");
        answer:
            answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            switch (answer)
            {
                case "exit":
                    Environment.Exit(0);
                    break;
                case "esc":
                    Environment.Exit(0);
                    break;
                case "kilep":
                    Environment.Exit(0);
                    break;
                case "ki":
                    Environment.Exit(0);
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
                case "again":
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    goto start;
                case "start":
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    goto start;
                case "s":
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    goto start;
                case "restart":
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    goto start;
                case "r":
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    goto start;
                case "ver":
                    Console.WriteLine("Version: 1.0");
                    goto answer;
                case "version":
                    Console.WriteLine("Version: 1.0");
                    goto answer;
                case "v":
                    Console.WriteLine("Version: 1.0");
                    goto answer;
                case "":
                    Console.Clear();
                    Console.WriteLine("exit     -> kilép a programból");
                    Console.WriteLine("start    -> a program elejére dob");
                    Console.WriteLine("version  -> kiírja a program verziószámát");
                    Console.WriteLine("help     -> kiírja ezt az üzenetet");
                    goto answer;
                case "help":
                    Console.Clear();
                    Console.WriteLine("exit     -> kilép a programból");
                    Console.WriteLine("start    -> a program elejére dob");
                    Console.WriteLine("version  -> kiírja a program verziószámát");
                    Console.WriteLine("help     -> kiírja ezt az üzenetet");
                    goto answer;
                    
                





            }


        }
    }
}
