public class PlayerInventory : MonoBehaviour
{  
    //Adding a test comment 

    //Constructor: initalize an empty dictionary 
    public PlayerInventory (Dictionary<string, Dictionary<string, int>> inventory) {
        inventory = new Dictionary<string, Dictionary<string, int>>(); 
    }

    //Adds medicine within the medicine bag
    public void addPlayer_Medication(TKey key, TValue value)
    {
        bag.Add(key, value); 
    } 

    public void player_PokeBalls(TKey key, TValue value)
    {
        bag.Add(key, value);  
    } 

    //Check if item is contained in the inventory (player bag)
    public bool containsItem(string item)
    {
        //bool represents if item can be used or not 
        bool use = false; 
        //Check if the item is contained in the bag 
        foreach(Dictionary<string, int> entry in bag)
        {
            //Check if the item exists in the bag 
            if(entry.key == item && entry.value >= 1)
            {
                use = true; 
            } 
        }
        return use; 
    } 
}