using UnityEngine;

public class PokemonBattle : Monobehaivour
{ 
    PlayerInventory medication = new PlayerInventory();  
    Pokemon bulbasaur = new Pokemon(); 

    Pokemon trainerSquirtle = new Pokemon(); 

    //Returns true if a player is able to use available items 
    public bool useMedicine(string item)
    {
       return medication.Contains(item);
    } 

    public void drainHP()
    {
        
    }

    //TODO: Calculate the pokemon damamge depending on the type of attack 
    public void calculateDamage() {

    }
}