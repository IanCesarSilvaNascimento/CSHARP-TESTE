using System;
using System.Text;

namespace HtmlEditor
{
    public static class Editor 
    {
        public static void New()
        {
            Console.Clear();
            Console.SetCursorPosition(10,2);
            Console.WriteLine("MODO EDITOR");

            Console.SetCursorPosition(6,0);
            var data = DateTime.Now;
            Console.WriteLine(data);

            Console.SetCursorPosition(0,4);
            Console.WriteLine("ESC- sair");


            Console.SetCursorPosition(0,5);
            Console.WriteLine("=====================================");

            Start();

        }

        public static void Start()
        {       
            var text = new StringBuilder();

            do{
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
                
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            SaveAnswer(text.ToString());       
            
        }

        public static void SaveAnswer(string text)
        {
               
            Console.Clear();                 
            Console.WriteLine("Deseja Salvar o arquivo? (s/n)");                    
            char answer = char.Parse(Console.ReadLine());
         
                if(answer == 's')
                    SavePath(text.ToString());
                else {
                    Console.Clear();
                    Environment.Exit(0);
                }
         
        }

        public static void SavePath(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho deseja salvar?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);

            }
            Console.WriteLine("\n");
            Console.WriteLine($"Arquivo salvo com sucesso em {path}");
        }
    }

}