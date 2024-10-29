using System;

class Program
{
    // Método principal que inicia a aplicação
    static void Main(string[] args)
    {
        // Criação do guerreiro jogador com nome, ataque, defesa e vida
        Guerreiro jogador = new Guerreiro("Bjorn(Você)", 52, 10, 100);
        
        // Criação do guerreiro inimigo com nome, ataque, defesa e vida
        Guerreiro inimigo = new Guerreiro("Ragnar", 33, 20, 150);

        // Aplicação do Decorator Anel ao jogador, permitindo que ele tenha um anel
        AnelDecorator anel = new AnelDecorator(jogador);

        // Inicialização do jogo com o jogador e o inimigo
        Jogo jogo = new Jogo(jogador, inimigo);
        
        // Início do jogo
        jogo.Iniciar();
    }
}
