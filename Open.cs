using System;

namespace HtmlEditor
{

    public static class Open
    {

        public static void Show()
        {
            Console.Clear();
            Console.SetCursorPosition(10,2);
            Console.WriteLine("MODO ABRIR ARQUIVO");

            Console.SetCursorPosition(6,0);
            var data = DateTime.Now;
            Console.WriteLine(data);

            Console.SetCursorPosition(0,3);
            Console.WriteLine("=====================================");

            
        }

        public static void Start()
        {

        }
    }

}