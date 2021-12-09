using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public GameDatabase m_gameDatabase;
    public Card generatedCard;

    private string[] names = { "Garrosh", "Deathwing", "Arthas", "Archimonde" };
    private string[] descriptions = { "This is description 1", "This is descripton 2", "This is description 3", "This is description 4" };

    public void GenerateCard()
    {
        generatedCard = ScriptableObject.CreateInstance<Card>();
        generatedCard.cardImage = m_gameDatabase.cardSprite;
        generatedCard.cardIllustration = m_gameDatabase.illustration1;
        generatedCard.cardName = names[0];
        generatedCard.description = descriptions[0];
        generatedCard.hp = 1;
        generatedCard.mana = 2;
        generatedCard.speed = 3;
    }
}