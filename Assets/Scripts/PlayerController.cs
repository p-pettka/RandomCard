using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text hp;
    public Text mana;
    public Text speed;

    public int playerHp;
    public int playerMana;
    public int playerSpeed;

    public void UpdatePlayerStats()
    {
        hp.text = "HP: " + playerHp.ToString();
        mana.text = "Mana: " + playerMana.ToString();
        speed.text = "Speed: " + playerSpeed.ToString() + "%";
    }

    private void Start()
    {
        playerHp = 50;
        playerMana = 20;
        playerSpeed = 100;

        UpdatePlayerStats();
    }
}
