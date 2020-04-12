using System;
using TextCopy;

namespace paste
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                    Clipboard.SetText(args[0]);
                var clipboard = Clipboard.GetText();
                Console.WriteLine(clipboard);
            }
            catch (System.Exception) { }
        }
    }
}