
public class Pokemon : Monobehaivour
{
    public int attack, speed, spAtk, spDef, defense, HP; 

    //Constructor 
    public Pokemon(attack, speed, spAtk, spDef, defense)
    {
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
    }
}