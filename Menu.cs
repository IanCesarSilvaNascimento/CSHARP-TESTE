using System;
using System.Threading;


namespace HtmlEditor
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            
            ScreenSketch();
         
            Options();
                    
            var menuOption = short.Parse(Console.ReadLine());

            HandleMenuOption(menuOption);
            
        }

        public static void ScreenSketch()
        {   
            
            Console.Write("x");
            for(int i=0; i<30; i++)
                Console.Write("-");
            Console.Write("x");
            Console.Write("\n");

            for(int j=0; j<10; j++)
            {
                Console.Write("|");
                for(int k=0; k<30; k++)
                    Console.Write(" ");
                 Console.Write("|");
                 Console.Write("\n");
            }

            Console.Write("x");
            for(int i=0; i<30; i++)
                Console.Write("-");
            Console.Write("x");
            Console.Write("\n");

        }
    
        public static void Options()

        {
            Console.SetCursorPosition(10,2);
            Console.WriteLine("EDITOR HTML");

            Console.SetCursorPosition(6,0);
            var data = DateTime.Now;
            Console.WriteLine(data);

            Console.SetCursorPosition(3,4);
            Console.WriteLine("1- Novo arquivo");

            Console.SetCursorPosition(3,5);
            Console.Write("2- Abrir arquivo  ");

            Console.SetCursorPosition(3,6);
            Console.Write("3- Sair");

                      
            Console.SetCursorPosition(2,9);            
            Console.Write("Opção:  ");

        }
    
        public static void HandleMenuOption(short menuOption)
        {
            switch(menuOption)
            {
                case 1: Editor.New(); break;
                case 2: Open.Show(); break;
                case 3: {
                    Console.Clear();
                    Environment.Exit(0);
                } break;
                default: Show(); break;
            }
        }
    }


}