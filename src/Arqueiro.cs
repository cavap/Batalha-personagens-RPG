namespace jogo_rpg.src
{
    public class Arqueiro : Personagem
    {
        public Arqueiro(string nome)
        {
            this.nome = nome;
            this.modificadorDeVida = 2;
            this.modificadorDeDefesa = 2;
            this.modificadorDeAtaque = 2;

            this.vida *= this.modificadorDeVida;
        }
    }
}