using UnityEngine;

public class Pokemon : Monobehaivour
{
    public int attack, speed, spAtk, spDef, defense, HP, level, power; 
    //Constructor 
    public Pokemon(int attack, int speed, int spAtk, int spDef, int defense, int HP, int level)
    {
        this.pokemonName = pokemonName; 
        this.attack = attack;
        this.speed = speed;
        this.spAtk = spAtk;
        this.spDef = spDef;
        this.defense = defense;
        this.HP = HP; 
        this.level = level; 
    }

    public int getLevel() {
        return this.level; 
    }

    public int getHP () {
        return this.HP; 
    }

    //Represents the base attack stat of the pokemon itself.
    public int getAttackStat() {
        return this.attack; 
    }

    public int getDefenseStat() {
        return this.defense; 
    }

    public int getSpeedStat() {
        return this.speed; 
    }

    public int getSpAttk() {
        return this.spAtk; 
    }

    //Get the power of of the used move 
    public double getPower(Pokemon pokemon) {
        
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
        Tackle, 
        TailWhip, 
        Bite
    }; 

    public void RandomizeAttack() {
        //Add a dictionary which includes attack and attack power 
    }
}