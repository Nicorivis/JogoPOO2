public class Guerreiro
{
    public string Nome { get; set; } // Nome do guerreiro
    public virtual double Ataque { get; set; } // Propriedade de ataque, marcada como virtual para permitir sobrescrita
    public virtual double Defesa { get; set; } // Propriedade de defesa, marcada como virtual para permitir sobrescrita
    public int Vida { get; set; } // Vida atual do guerreiro
    public bool TemAnel { get; set; } // Indica se o guerreiro possui um anel que reflete dano
    public double PorcentagemReflexo { get; set; } // Percentual de dano que o guerreiro reflete quando possui um anel

    // Construtor que inicializa os atributos do guerreiro
    public Guerreiro(string nome, double ataque, double defesa, int vida)
    {
        Nome = nome; // Define o nome do guerreiro
        Ataque = ataque; // Define o ataque do guerreiro
        Defesa = defesa; // Define a defesa do guerreiro
        Vida = vida; // Define a vida do guerreiro
        TemAnel = false; // Inicializa a propriedade TemAnel como false
        PorcentagemReflexo = 0; // Inicializa a porcentagem de reflexo como 0
    }

    // Método que determina se o guerreiro consegue esquivar de um ataque
    public bool Esquivar()
    {
        Random random = new Random(); // Cria um novo objeto Random para gerar números aleatórios
        return random.NextDouble() < 0.17; // 17% de chance de esquivar (retorna true se o número gerado for menor que 0.17)
    }

    // Método para causar dano a outro guerreiro
    public void CausarDano(Guerreiro alvo)
    {
        double dano = Ataque - alvo.Defesa; // Calcula o dano levando em consideração a defesa do alvo

        if (dano > 0) // Se o dano é positivo
        {
            // Verifica se o alvo tem o anel para calcular o dano refletido
            if (alvo.TemAnel)
            {
                double danoRefletido = dano * (alvo.PorcentagemReflexo / 100); // Calcula o dano refletido
                Console.WriteLine($"{alvo.Nome} refletiu {danoRefletido} de dano!"); // Informa que o dano foi refletido
                alvo.Vida -= (int)dano - (int)danoRefletido; // Aplica o dano considerando o reflexo
            }
            else
            {
                alvo.Vida -= (int)dano; // Aplica o dano normal
            }
        }

        Console.WriteLine($"{alvo.Nome} agora tem {alvo.Vida} de vida."); // Exibe a vida restante do alvo
    }
}
