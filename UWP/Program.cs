namespace LetsCreatePokemon;

public static class Program
{
    public static void Main(string[] args)
    {
        using var game = new PokemonGame();
        game.Run();
    }
}