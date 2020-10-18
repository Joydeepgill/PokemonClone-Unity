using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PokemonBattle : Monobehaivour
{  
    PlayerInventory medication = new PlayerInventory();  
    Pokemon bulbasaur = new Pokemon(49, 45, 65, 65, 45); 
    Pokemon trainerSquirtle = new Pokemon();  

     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    //Returns true if a player is able to use available items 
    public bool useMedicine(string item)
    {
        if (useMedicine.Contains(item)) {
            Console.WriteLine("You can use the medicine"); 
        } else {
            Console.WriteLine("Sorry you cannot use the medicine item you selected"); 
        }
    } 
    //Level change, damage, 
    public int drainHP(Pokemon pokemon)
    {
        int baseHP = pokemon.getHP(); 
        int powerMove = pokemon.getPower(); 
        int currentHP = baseHP - powerMove; 
        return currentHP; 
    }

    //TODO: Calculate the pokemon damamge depending on the type of attack 
    //Pass in attack type
    public void calculateDamage(Pokemon pokemon) {
        //get the pokemon attack type & power 
        int lvl = pokemon.getLevel(); 
        int attkPwer = pokemon.getAttackPower(); 

        //TODO: Damage formula 
        int damage = Math.Floor((2 + lvl/ 5 + 2));
    }
}