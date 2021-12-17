using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public Sprite cardImage;
    public Sprite cardIllustration;
    public string cardName;
    public string description;
    public int hp;
    public int mana;
    public int speed;
}