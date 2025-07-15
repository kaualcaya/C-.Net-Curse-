namespace variaveis;

public class Program
{
    public static void Main()
    {
        int idade = 25; // Número inteiro (32 bits)
        long id = 1234567890; // Número inteiro grande (64 bits)
        short numeroPequeno = 32000; // Número inteiro menor (16 bits)
        byte valorByte = 255; // Número pequeno de 0 a 255 (8 bits)

        float temperatura = 36.5f; // Número com casas decimais, precisa do 'f' no final
        double altura = 1.78; // Número decimal (64 bits), mais usado que float
        decimal salario = 1500.75m; // Alta precisão para dinheiro, usa 'm'

        char inicial = 'K'; // Um único caractere
        string nome = "Kauã"; // Texto (cadeia de caracteres)

        bool ativo = true; // Booleano: verdadeiro ou falso
        bool concluido = false;

        DateTime agora = DateTime.Now; // Data e hora atual
        TimeSpan duracao = TimeSpan.FromMinutes(90); // Duração de tempo

        var cidade = "São Paulo"; // C# infere o tipo automaticamente (aqui é string)
        object qualquerCoisa = 123; // Pode guardar qualquer tipo (tipo base de todos)
        dynamic valorDinamico = "texto"; // Tipo dinâmico: tipo decidido em tempo de execução

        int? idadeOpcional = null; // Tipo inteiro que aceita nulo (nullable)

        Console.WriteLine($"Nome: {nome}, Idade: {idade} ");
    }
}