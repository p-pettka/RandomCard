using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Card currentCard;
    public Image cardImage;
    public Image cardIllustration;
    public Text cardName;
    public Text cardDescription;
    public Text hp;
    public Text mana;
    public Text speed;

    public void UpdateCard()
    {
        cardImage.sprite = currentCard.cardImage;
        cardIllustration.sprite = currentCard.cardIllustration;
        cardName.text = currentCard.cardName;
        cardDescription.text = currentCard.description;
        hp.text = currentCard.hp.ToString();
        mana.text = currentCard.mana.ToString();
        speed.text = currentCard.speed.ToString();
    }
}
