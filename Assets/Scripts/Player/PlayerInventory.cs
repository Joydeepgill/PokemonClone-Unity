public class PlayerInventory : MonoBehaviour
{
    Dictionary<string, int> medicineBag = new Dictionary<string, int>();
    Dictionary<string, int> pokeBallBag = new Dictionary<string, int>();

    //Adds medicine within the medicine bag
    public void addPlayer_Medication(TKey key, TValue value)
    {
        medicineBag.Add(key, value); 
    } 

    public void player_PokeBalls(TKey key, TValue value)
    {
        pokeBallBag.Add(key, value);  
    } 

    //Check if item is contained in the inventory (player bag)
    public bool containsItem(string item)
    {
        //bool represents if item can be used or not 
        bool use = false; 
        //Check if the item is contained in the medicine bag 
        foreach(Dictionary<string, int> entry in medicineBag)
        {
            if(entry.key == item && entry.value >= 1)
            {
                use = true; 
            } 
        }
        return use; 
    } 
}