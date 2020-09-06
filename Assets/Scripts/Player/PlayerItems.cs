public class PlayerItems : MonoBehaviour
{
    Dictionary<string, int> medicine = new Dictionary<string, int>();
    Dictionary<string, int> pokeBalls = new Dictionary<string, int>();

    public void player_Medication()
    {
        medicine.Add("Moomoo milk", 15);
        medicine.Add("Potion", 10);
        medicine.Add("Super Potion", 6);
        medicine.Add("Revive", 4);
    } 

    public void player_PokeBalls()
    {
        pokeBalls.Add("Poke Ball", 20);
        pokeBalls.Add("Great Ball", 15);
        pokeBalls.Add("Ultra Ball", 5);
        pokeBalls.Add("Safari Ball", 3);
    }
}