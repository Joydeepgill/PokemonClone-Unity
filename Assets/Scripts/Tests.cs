using UnityEngine;

public class Tests 
{
	void Start () {

	} 

	//Tests concerning the PlayerInventory class
	void TestPlayerInventory () {
		Dictionary<string, Dictionary<string, int>> myDict = new Dictionary<string, Dictionary<string, int>>(){
			{"Pokeballs", new Dictionary<string, int>{"Ultra Ball", 6, "Pokeball", 15}}, 
			{"Medicine",  new Dictionary<string, int>{"Burn Heal", 3, "Heal Powder", 2}}, 
		}; 

		joyInventory = new PlayerInventory(myDict); 
		joyInventory.addPlayer_Medication(); 
	}
}