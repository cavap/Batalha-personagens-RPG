namespace jogo_rpg.src
{
    public abstract class Personagem
    {
        public string? nome;
        protected int vida;
        protected int defesa;
        protected int ataque;
        protected int modificadorDeVida;
        protected int modificadorDeDefesa;
        protected int modificadorDeAtaque;
        Random geradorNumerosAleatorios;

        protected Personagem()
        {
            geradorNumerosAleatorios = new Random();
            this.vida = geradorNumerosAleatorios.Next(10,16);
            this.defesa = geradorNumerosAleatorios.Next(2,5);
            this.ataque = geradorNumerosAleatorios.Next(8,16);
        }

        public int CalcularAtaque()
        {
            return (this.ataque * this.modificadorDeAtaque) + geradorNumerosAleatorios.Next(0,6);
        }

        public int CalcularDefesa()
        {
            return this.defesa * this.modificadorDeDefesa;
        }

        public bool EstaVivo()
        {
            if(this.vida > 0)
            {
                return true;
            }

            return false;
        }

        public void Apanhar(int dano)
        {
            dano -= this.CalcularDefesa();
            if(dano > 0)
            {
                Console.WriteLine($"{this.nome} perdeu {dano} de vida");
                this.vida -= dano;
            }
            else
            {
                Console.WriteLine($"{this.nome} resistiu ao ataque");
            }
            
        }


    }
}