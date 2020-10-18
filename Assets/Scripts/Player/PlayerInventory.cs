using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

     //Constructor: initalize an empty dictionary 
    /*public PlayerInventory (Dictionary<string, Dictionary<string, int>> inventory) {
        inventory = new Dictionary<string, Dictionary<string, int>>(); 
    }*/ 

    //Adds medicine within the medicine bag
    public void addItem(Dictionary<string, Dictionary<string, int>> inventory)
    {
        inventory.Add(key, value); 
    }  

    //TODO: Method for deleting items from bag 
    public void removeItem(Dictionary<string, Dictionary<string, int>> inventory, string item) {
        //Check if item is already in bag (before removing it)
    }

    //Check if item is contained in the inventory (player bag)
    public bool containsItem(Dictionary<string, Dictionary<string, int>> inventory, string item)
    {
        //bool represents if item can be used or not 
        bool use = false; 
        //Check if the item is contained in the bag 
        foreach(string key in inventory.Keys)
        { 
            foreach (string innerkey in inventory[key].Keys) {
                Console.WriteLine(innerkey);
            }
            
            //Check if the item exists in the bag 
            /*if(entry.key == item && entry.value >= 1)
            {
                use = true; 
            }*/ 
        }
        return use; 
    } 
}
