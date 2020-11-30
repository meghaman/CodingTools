using CodingTools.DataStructures;

namespace CodingToolsTest.DataStructures
{
	public class LRUCache_Tests
	{
        private void CacheTest()
        {
            // Build Storage & Cache
            Storage storage = new Storage();
            storage.AddRecipe(new DessertRecipe() { Name = "Cake", Recipe = "Bake A Cake" });
            storage.AddRecipe(new DessertRecipe() { Name = "Pie", Recipe = "Fry A Pie" });
            storage.AddRecipe(new DessertRecipe() { Name = "Chicken", Recipe = "Flicken A Clicken" });
            storage.AddRecipe(new DessertRecipe() { Name = "Toast", Recipe = "Toast Bread" });
            storage.AddRecipe(new DessertRecipe() { Name = "Sandwich", Recipe = "Food between Slices" });

            Cache recipeCache = new Cache(ref storage);

            // User makes requests
            recipeCache.GetItemOutOfCache("Cake");
            recipeCache.GetItemOutOfCache("Pie");
            recipeCache.GetItemOutOfCache("Chicken");
            recipeCache.GetItemOutOfCache("Chicken");
            recipeCache.GetItemOutOfCache("Toast");
            recipeCache.GetItemOutOfCache("Sandwich");
            recipeCache.GetItemOutOfCache("Chicken");
            recipeCache.GetItemOutOfCache("Chicken");
            recipeCache.GetItemOutOfCache("Cake");
         }

	}
}
