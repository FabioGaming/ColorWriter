using System;
using System.Collections.Generic;
using System.Text; 

namespace ColorWriter
{
    class ColorWriter
    {
        //Allows you to Print colored text.
        //Example usage: ColorWriter.Print("this is green text", "green"); (If you don't change the NameSpace the usage is: ColorWriter.ColorWriter.Print("this is green text", "green"); )
        /* Color List
         * black
         * blue
         * cyan
         * darkblue (or dark_blue)
         * darkcyan (or dark_cyan)
         * darkgray (or dark_gray)
         * darkgreen (or dark_green)
         * darkmagenta (or dark_magenta)
         * darkred (or dark_red)
         * darkyellow (or dark_yellow)
         * gray
         * green
         * magenta
         * red
         * white
         * yellow
         */

        public static void Print(string message, string color)
        {
            color = color.ToLower();

            switch (color)
            {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "darkblue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dark_blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkcyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "dark_cyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkgray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "dark_gray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "darkgreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "dark_green":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkmagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "dark_magenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkred":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark_red":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkyellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "dark_yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
