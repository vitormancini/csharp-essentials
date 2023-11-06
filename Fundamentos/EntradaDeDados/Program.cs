// ReadLine: lê uma linha de entrada e retorna a string informada pelo usuário
Console.WriteLine("Obetendo dados pelo ReadLine:");
string readLine = Console.ReadLine();

Console.WriteLine($"String digitada: {readLine}");

// Read: lê um único caracter de entrada e retorna o valor ASCII deste caractere
Console.WriteLine("Obetendo dados pelo Read:");
int read = Console.Read();

Console.WriteLine($"Resultado Read: ${read}");


// ReadKey: lê um único caractere e obtem a tecla pressionada pelo usuário (ConsoleKeyInfo)
Console.WriteLine("Obetendo dados pelo ReadKey:");
ConsoleKeyInfo readkey = Console.ReadKey();
