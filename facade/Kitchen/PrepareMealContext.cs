using Madness.Dishes;
using Madness.Recipes;

namespace Madness
{
    // I am a facade, you only see the ready meal
    // the kitchen is an illusion 👻👻👻👻👻
    public interface IPrepareMealContext
    {
        BigMac PrepareBigMac();
    }

    public class PrepareMealContext
    {
        public BigMac PrepareBigMac()
        {
            var recipe = new BigMacRecipe();

            // get beef from fridge

            // get the tools

            // fry

            // etc...

            // hide composition of components, we just want a specific thing

            return new();
        }
    }
}