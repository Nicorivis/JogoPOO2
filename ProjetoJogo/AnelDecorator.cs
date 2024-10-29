public class AnelDecorator : Decorator
{
    // Construtor que inicializa o guerreiro com o anel e define a porcentagem de reflexo inicial
    public AnelDecorator(Guerreiro guerreiro) : base(guerreiro)
    {
        guerreiro.TemAnel = true; // Define que o guerreiro possui um anel
        guerreiro.PorcentagemReflexo = 10; // Porcentagem inicial de reflexo ao receber dano
    }

    // Método que permite ao guerreiro coletar uma Esfera de Poder
    public void ColetarEsferaDePoder()
    {
        // Verifica se a porcentagem de reflexo é menor que 100
        if (guerreiro.PorcentagemReflexo < 100)
        {
            guerreiro.PorcentagemReflexo += 10; // Aumenta a porcentagem do reflexo em 10%
            // Mensagem informando que o guerreiro coletou uma esfera e seu novo reflexo
            Console.WriteLine($"{guerreiro.Nome} coletou uma Esfera de Poder! Reflexo atual: {guerreiro.PorcentagemReflexo}%");
        }
        else
        {
            // Mensagem informando que o guerreiro já atingiu o máximo de reflexo
            Console.WriteLine($"{guerreiro.Nome} já tem o máximo de reflexo!");
        }
    }
}
