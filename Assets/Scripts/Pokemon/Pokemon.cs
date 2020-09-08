using UnityEngine;

public class Pokemon : Monobehaivour
{
    public int attackPower, speed, spAtk, spDef, defense, HP, level; 
    //Constructor 
    public Pokemon(int attackPower, int speed, int spAtk, int spDef, int defense, int HP, int level)
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

    public int getAttackPower() {
        return this.attackPower; 
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
}