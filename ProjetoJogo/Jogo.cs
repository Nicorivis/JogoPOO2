using System;

public class Jogo
{
    private Guerreiro jogador; // O guerreiro que o jogador controla
    private Guerreiro inimigo; // O guerreiro inimigo

    // Construtor que inicializa o jogo com um jogador e um inimigo
    public Jogo(Guerreiro jogador, Guerreiro inimigo)
    {
        this.jogador = jogador; // Atribui o jogador
        this.inimigo = inimigo; // Atribui o inimigo
    }

    // Método que inicia o jogo
    public void Iniciar()
    {
        ApresentarGuerreiros(); // Exibe informações sobre os guerreiros

        Random random = new Random();
        bool turnoJogador = random.Next(0, 2) == 0; // Determina aleatoriamente quem ataca primeiro

        // Loop principal do jogo que continua enquanto ambos os guerreiros estiverem vivos
        while (jogador.Vida > 0 && inimigo.Vida > 0)
        {
            Console.WriteLine(new string('=', 50)); // Linha de separação
            if (turnoJogador)
            {
                Console.WriteLine($"É a vez de {jogador.Nome} atacar!"); // Indica que é a vez do jogador
                JogadorAtaca(); // Chama o método para o jogador atacar
            }
            else
            {
                Console.WriteLine($"É a vez de {inimigo.Nome} atacar!"); // Indica que é a vez do inimigo
                InimigoAtaca(); // Chama o método para o inimigo atacar
            }
            Console.WriteLine(new string('=', 50)); // Linha de separação

            turnoJogador = !turnoJogador; // Alterna entre o jogador e o inimigo

            // Verifica se algum guerreiro foi derrotado
            if (jogador.Vida <= 0)
            {
                Console.WriteLine($"{jogador.Nome} foi derrotado!"); // Exibe mensagem de derrota do jogador
                break; // Sai do loop
            }
            if (inimigo.Vida <= 0)
            {
                Console.WriteLine($"{inimigo.Nome} foi derrotado!"); // Exibe mensagem de derrota do inimigo
                break; // Sai do loop
            }

            // Pergunta se o jogador deseja continuar
            if (!PerguntarContinuar())
            {
                Console.WriteLine($"{jogador.Nome} desistiu da luta. Derrota!"); // Mensagem de desistência
                break; // Sai do loop
            }
        }
    }

    // Método que apresenta informações dos guerreiros no início do jogo
    private void ApresentarGuerreiros()
    {
        Console.WriteLine($"Guerreiro 1: {jogador.Nome} | Vida: {jogador.Vida} | Ataque: {jogador.Ataque} | Defesa: {jogador.Defesa}");
        Console.WriteLine($"Guerreiro 2: {inimigo.Nome} | Vida: {inimigo.Vida} | Ataque: {inimigo.Ataque} | Defesa: {inimigo.Defesa}");
        Console.WriteLine(new string('=', 50)); // Linha de separação
    }

    // Método que gerencia o ataque do jogador ao inimigo
    private void JogadorAtaca()
    {
        if (inimigo.Esquivar()) // Verifica se o inimigo consegue esquivar
        {
            Console.WriteLine($"{inimigo.Nome} desviou do ataque de {jogador.Nome}!"); // Mensagem de esquiva
        }
        else
        {
            jogador.CausarDano(inimigo); // Causa dano ao inimigo
            Console.WriteLine($"{jogador.Nome} causou dano a {inimigo.Nome}!"); // Mensagem de dano
            Console.WriteLine($"{inimigo.Nome} agora tem {inimigo.Vida} de vida."); // Exibe vida restante do inimigo
        }
    }

    // Método que gerencia o ataque do inimigo ao jogador
    private void InimigoAtaca()
    {
        if (jogador.Esquivar()) // Verifica se o jogador consegue esquivar
        {
            Console.WriteLine($"{jogador.Nome} desviou do ataque de {inimigo.Nome}!"); // Mensagem de esquiva
        }
        else
        {
            inimigo.CausarDano(jogador); // Causa dano ao jogador
            Console.WriteLine($"{inimigo.Nome} causou dano a {jogador.Nome}!"); // Mensagem de dano
            Console.WriteLine($"{jogador.Nome} agora tem {jogador.Vida} de vida."); // Exibe vida restante do jogador
        }
    }

    // Método que pergunta ao jogador se ele deseja continuar ou desistir
    private bool PerguntarContinuar()
    {
        Console.WriteLine("Escolha uma opção:"); // Mensagem de opções
        Console.WriteLine("1 - Próximo turno"); // Opção para continuar
        Console.WriteLine("2 - Desistir da luta"); // Opção para desistir
        string escolha = Console.ReadLine(); // Lê a entrada do jogador

        return escolha == "1"; // Retorna true se o jogador quiser continuar
    }
}
