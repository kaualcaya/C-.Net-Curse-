using system;


namespace LoginInput // Organização do código
{
    public static class Entrada // Classe utilitária (não precisa de new)
    {
        public static string PedirNome() // Método acessível fora da classe
        {
            Console.Write("Seu nome é: ");
            Console.Write("Sua senha é: ");
            return Console.ReadLine();
        }
    }
}

namespace LoginOutput
{
    public static class Saida
    {
        public static string
    }
}