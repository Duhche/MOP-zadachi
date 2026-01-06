using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace MOP_zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an operation:");
            Console.WriteLine("1 = Binary");
            Console.WriteLine("2 = Octal");
            Console.WriteLine("3 = Decimal");
            Console.WriteLine("4 = Hexadecimal");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Convert to: 1=Octal 2=Decimal 3=Hex");
                int choice2 = int.Parse(Console.ReadLine());
                Console.Write("Enter binary number: ");
                string bin = Console.ReadLine();

                if (choice2 == 1) Console.WriteLine(BinToOct(bin));
                else if (choice2 == 2) Console.WriteLine(BinToDec(bin));
                else if (choice2 == 3) Console.WriteLine(BinToHex(bin));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Convert to: 1=Binary 2=Decimal 3=Hex");
                int choice2 = int.Parse(Console.ReadLine());
                Console.Write("Enter octal number: ");
                string oct = Console.ReadLine();

                if (choice2 == 1) Console.WriteLine(OctToBin(oct));
                else if (choice2 == 2) Console.WriteLine(OctToDec(oct));
                else if (choice2 == 3) Console.WriteLine(OctToHex(oct));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Convert to: 1=Binary 2=Octal 3=Hex");
                int choice2 = int.Parse(Console.ReadLine());
                Console.Write("Enter decimal number: ");
                int dec = int.Parse(Console.ReadLine());

                if (choice2 == 1) Console.WriteLine(DecToBin(dec));
                else if (choice2 == 2) Console.WriteLine(DecToOct(dec));
                else if (choice2 == 3) Console.WriteLine(DecToHex(dec));
            }
            else if (choice == 4)
            {
                Console.WriteLine("Convert to: 1=Binary 2=Octal 3=Decimal");
                int choice2 = int.Parse(Console.ReadLine());
                Console.Write("Enter hex number: ");
                string hex = Console.ReadLine().ToUpper();

                if (choice2 == 1) Console.WriteLine(HexToBin(hex));
                else if (choice2 == 2) Console.WriteLine(HexToOct(hex));
                else if (choice2 == 3) Console.WriteLine(HexToDec(hex));
            }

            Console.ReadLine();
        }

        
        static string DecToBin(int n)
        {
            if (n == 0) return "0";
            string res = "";
            while (n > 0)
            {
                res = (n % 2) + res;
                n /= 2;
            }
            return res;
        }

        static string DecToOct(int n)
        {
            if (n == 0) return "0";
            string res = "";
            while (n > 0)
            {
                res = (n % 8) + res;
                n /= 8;
            }
            return res;
        }

        static string DecToHex(int n)
        {
            if (n == 0) return "0";
            string res = "";
            while (n > 0)
            {
                int r = n % 16;
                if (r < 10) res = r + res;
                else res = (char)('A' + r - 10) + res;
                n /= 16;
            }
            return res;
        }

        
        static int BinToDec(string bin)
        {
            int res = 0;
            int power = 0;

            foreach (char c in bin.Reverse())
            {
                if (c == '1')
                    res += (int)Math.Pow(2, power);
                power++;
            }
            return res;
        }

        static string BinToOct(string bin)
        {
            return DecToOct(BinToDec(bin));
        }

        static string BinToHex(string bin)
        {
            return DecToHex(BinToDec(bin));
        }

        
        static int OctToDec(string oct)
        {
            int res = 0;
            int power = 0;

            foreach (char c in oct.Reverse())
            {
                res += (c - '0') * (int)Math.Pow(8, power);
                power++;
            }
            return res;
        }

        static string OctToBin(string oct)
        {
            return DecToBin(OctToDec(oct));
        }

        static string OctToHex(string oct)
        {
            return DecToHex(OctToDec(oct));
        }

        
        static int HexToDec(string hex)
        {
            int res = 0;
            int power = 0;

            foreach (char c in hex.Reverse())
            {
                int val;
                if (c >= '0' && c <= '9')
                    val = c - '0';
                else
                    val = c - 'A' + 10;

                res += val * (int)Math.Pow(16, power);
                power++;
            }
            return res;
        }

        static string HexToBin(string hex)
        {
            return DecToBin(HexToDec(hex));
        }

        static string HexToOct(string hex)
        {
            return DecToOct(HexToDec(hex));
        }
    }
}
