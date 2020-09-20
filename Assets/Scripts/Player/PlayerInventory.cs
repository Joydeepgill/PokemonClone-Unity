public class PlayerInventory : MonoBehaviour
{
    var bag = new Dictionary<srting, Dictionary<string, int>>{
        {"Medicine", new Dictionary<string, int>{{"Burn Heal", 1}, {"Potion", 10}, {"Heal Powder", 1}}}, 
        {"PokeBall", new Dictionary<string, int>{{"Pokeball", 15}, {"Friend Ball", 20}, {"Ultra Ball", 20}}}
    }; 

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