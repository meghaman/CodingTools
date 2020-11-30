using System.Collections.Generic;

namespace CodingTools.DataStructures
{
    public class Cache
    {
        LinkedList<DessertRecipe> cache;
        Dictionary<string, LinkedListNode<DessertRecipe>> hash;
        Storage storage;
        const int MaxCacheSize = 2;

        public Cache(ref Storage _storage)
        {
            cache = new LinkedList<DessertRecipe>();
            hash = new Dictionary<string, LinkedListNode<DessertRecipe>>();
            storage = _storage;
        }

        public DessertRecipe GetItemOutOfCache(string _name)
        {
            // Is item in cache
            if (!hash.ContainsKey(_name))
            {
                // If not get from storage and store in cache
                if (cache.Count >= MaxCacheSize)
                {
                    hash.Remove(cache.Last.Value.Name);
                    cache.RemoveLast();
                }

                cache.AddFirst(GetItemFromStorage(_name));
                hash.Add(_name, cache.First);
            }
            else
            {
                // Move item to top of cache
                System.Console.WriteLine("Getting " + _name + " recipe out of cache");
            }

            return hash[_name].Value;
        }

        private DessertRecipe GetItemFromStorage(string _name)
        {
            return storage.GetRecipeFromStorage(_name);
        }
    }

    public class Storage
    {
        List<DessertRecipe> recipes;

        public Storage()
        {
            recipes = new List<DessertRecipe>();
        }

        public DessertRecipe GetRecipeFromStorage(string _name)
        {
            System.Console.WriteLine("Getting " + _name + " recipe out of storage");
            return recipes.Find(recipe => recipe.Name == _name);
        }

        public void AddRecipe(DessertRecipe recipe)
        {
            recipes.Add(recipe);
        }
    }

    public class DessertRecipe
    {
        public string Name { get; set; }
        public string Recipe { get; set; }
    }
}
