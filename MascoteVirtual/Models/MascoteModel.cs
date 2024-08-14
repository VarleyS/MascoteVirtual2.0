namespace MascoteVirtual.Models
{
    public class MascoteModel : PokemonModel
    {
        public Atributos.Atributos hungry { get; set; }
        public Atributos.Atributos sleepy { get; set; }
        public Atributos.Atributos happiness { get; set; }
        public Atributos.Atributos tiredness { get; set; }
        public Atributos.Atributos health { get; set; }


        public MascoteModel(PokemonModel pokemon)
        {
            Nome = pokemon.Nome;
            Altura = pokemon.Altura;
            Peso = pokemon.Peso;
            Abilidades = pokemon.Abilidades;
        }
    }
}
