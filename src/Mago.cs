namespace jogo_rpg.src
{
    public class Mago : Personagem
    {
        public Mago(string nome)
        {
            this.nome = nome;
            this.modificadorDeVida = 1;
            this.modificadorDeDefesa = 1;
            this.modificadorDeAtaque = 3;

            this.vida *= this.modificadorDeVida;
        }
    }
}