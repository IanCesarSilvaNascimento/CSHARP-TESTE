# HtmlEditor
Editor de texto desenvolvido com intuito de testar fundamentos da linguagem C#

## Program.cs
Contém o método principal apenas iniciando com um método menu. 

```Code
Menu.Show();
```
## Menu.cs
Desenha um esboço de tela no terminal a partir do loop For e apresenta opções.Ademais invoca os métodos solicitados com base nas opções apresentadas. 
```Code
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
```
## Editor.cs
Apresenta uma nova tela no terminal chamada de MODO EDITOR.Recebe a informação digitada e salva em um caminho autorizado quando acionado ESC.
```Code
 Console.Clear();
            Console.SetCursorPosition(10,2);
            Console.WriteLine("MODO EDITOR");

            Console.SetCursorPosition(6,0);
            var data = DateTime.Now;
            Console.WriteLine(data);

```
```Code
var text = new StringBuilder();

            do{
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
                
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
```


```Code
Console.WriteLine("Qual caminho deseja salvar?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);

            }
```
## Utilização
Para utilizar a aplicação simplesmente use o comando dentro do diretório no terminal:

```bash
dotnet run
```

## Contribuição

Dicas sobre organização de código e melhoras de perfomance são bem vindas, porém pull request's não serão analisados.O objetivo deste conteúdo é treinar e aplicar alguns fundamentos da linguagem C#. 


