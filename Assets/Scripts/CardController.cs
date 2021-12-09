using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Card generatedCard;
    public Image cardImage;
    public Image cardIllustration;
    public Text cardName;
    public Text cardDescription;
    public Text hp;
    public Text mana;
    public Text speed;

    public void Start()
    {
        cardImage.sprite = generatedCard.cardImage;
        cardIllustration.sprite = generatedCard.cardIllustration;
        cardName.text = generatedCard.cardName;
        cardDescription.text = generatedCard.description;
        hp.text = generatedCard.hp.ToString();
        mana.text = generatedCard.mana.ToString();
        speed.text = generatedCard.speed.ToString();
    }
}
