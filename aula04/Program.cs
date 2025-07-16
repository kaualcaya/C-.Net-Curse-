


namespace LoginInput // Organização do código
{
    public static class Entrada // Classe utilitária (não precisa de new)
    {
        public static string PedirNome() // Método acessível fora da classe
        {
            Console.Write("Seu nome é: ");
            return Console.ReadLine();
        }
    }
}


namespace PasswordInput
{
    public static class EntradaDois
    {
        public static string PedirSenha()
        {
            Console.Write("Sua Senha:");
            return Console.ReadLine();
        }
    }
}

namespace MensagemSaida
{
    public static class MensagemSaida
    {
        public static void MostrarMensagem(string nome)
        {
            Console.WriteLine($"Login Efetuado com sucesso, {nome}");
        }
    }
}

namespace LoginApp
{
    using LoginInput;
    using MensagemSaida;
    using PasswordInput;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------Login--------");

            string nome = Entrada.PedirNome();
            MensagemSaida.MostrarMensagem(nome);
        }

    }

    

}