namespace jogo_rpg.src
{
    public class Batalha
    {
        private Personagem p1;
        private Personagem p2;

        public Batalha(Personagem p1, Personagem p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        private void Atacar()
        {
            p1.Apanhar(this.p2.CalcularAtaque() - this.p1.CalcularDefesa());
            p2.Apanhar(this.p1.CalcularAtaque() - this.p2.CalcularDefesa());
            if(!this.p1.EstaVivo()) Console.WriteLine($"{this.p1.nome} foi derrotado");
            if(!this.p2.EstaVivo()) Console.WriteLine($"{this.p2.nome} foi derrotado");
        }

        public void RealizarBatalha()
        {
            Console.WriteLine($"Iniciando batalha entre {this.p1.nome} e {this.p2.nome}");
            while(this.p1.EstaVivo() && this.p2.EstaVivo())
            {
                this.Atacar();
            }

            if(this.p1.EstaVivo())
            {
                Console.WriteLine($"{this.p1.nome} eh o vencedor");
            }
            else
            {
                if(this.p2.EstaVivo())
                {
                    Console.WriteLine($"{this.p2.nome} eh o vencedor");
                }
                else
                {
                    Console.WriteLine("empate");
                }
            }
        }
    }
}