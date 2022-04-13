using jogo_rpg.src;

namespace jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Arqueiro arqueiro;
            Guerreiro guerreiro;
            Mago mago;
            Batalha batalha;
            
            arqueiro = new Arqueiro("arqueiro");
            guerreiro = new Guerreiro("guerreiro");
            batalha = new Batalha(arqueiro, guerreiro);
            batalha.RealizarBatalha();

            Console.WriteLine("---------------------");

            mago = new Mago("mago");
            guerreiro = new Guerreiro("guerreiro");
            batalha = new Batalha(mago, guerreiro);
            batalha.RealizarBatalha();

            Console.WriteLine("---------------------");
            
            arqueiro = new Arqueiro("arqueiro");
            mago = new Mago("mago");
            batalha = new Batalha(arqueiro, mago);
            batalha.RealizarBatalha();
        }
    }
}
