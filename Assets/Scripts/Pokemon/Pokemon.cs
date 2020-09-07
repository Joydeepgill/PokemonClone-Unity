using UnityEngine;

public class Pokemon : Monobehaivour
{
    public int attackPower, speed, spAtk, spDef, defense, HP; 
    //Constructor 
    public Pokemon(int attackPower, int speed, int spAtk, int spDef, int defense, int HP)
    {
        this.pokemonName = pokemonName; 
        this.attack = attack;
        this.speed = speed;
        this.spAtk = spAtk;
        this.spDef = spDef;
        this.defense = defense;
        this.HP = HP; 
    }

    //Enum representing different pokemon types 
    enum pokemon_types
    {
        Fire, 
        Ice, 
        Flying, 
        Fighting, 
        Bug, 
        Dragon, 
        Ghost, 
        Fairy,
        Normal, 
        Dark,
        Psychic, 
        Poison,
        Rock, 
        Steel,
        Water,
        Ground 
    }; 

    enum attack_types
    {
        physical, 
        special
    }; 

    enum attacks {
        tackle, 
        
    }; 
}