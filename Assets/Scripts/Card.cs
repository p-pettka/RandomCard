using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public Sprite cardImage;
    public Sprite cardIllustration;
    public int hp;
    public int mana;
    public int speed;
}