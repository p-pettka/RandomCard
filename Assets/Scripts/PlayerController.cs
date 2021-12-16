using System.Collections;
using System.Collections.Generic;
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
        speed.text = "Speed: " + playerSpeed.ToString();
    }

    private void Start()
    {
        playerHp = 20;
        playerMana = 10;
        playerSpeed = 50;

        UpdatePlayerStats();
    }
}
