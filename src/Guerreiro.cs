namespace jogo_rpg.src
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome)
        {
            this.nome = nome;
            this.modificadorDeVida = 3;
            this.modificadorDeDefesa = 3;
            this.modificadorDeAtaque = 1;

            this.vida *= this.modificadorDeVida;
        }
    }
}