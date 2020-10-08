using UnityEngine;

public class Tests 
{
	void Start () {

	} 

	//Tests concerning the PlayerInventory class
	void TestPlayerInventory () {
		var bag = new Dictionary<srting, Dictionary<string, int>>{
        {"Medicine", new Dictionary<string, int>{{"Burn Heal", 1}, {"Potion", 10}, {"Heal Powder", 1}}}, 
        {"PokeBall", new Dictionary<string, int>{{"Pokeball", 15}, {"Friend Ball", 20}, {"Ultra Ball", 20}}}
    	};    

    	
	}
}