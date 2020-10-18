using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonIventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    ArrayList pokemons = new ArrayList(); 

	void addPokemon(Pokemon pokemon)
    {
        //Add pokemon if inventory is not full 
        if(pokemon.size() > 6)
        {
            pokemons.Add(pokemon); 
        } else
        {
            Console.WriteLine("Cannot add any more pokemon");
        }
    } 

    //Remove pokemon from the pokemon inventory 
    void removePokemon(Pokemon pokemon)
    {
        pokemons.remove(pokemon); 
    }
}
