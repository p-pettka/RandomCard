using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public GameDatabase m_gameDatabase;
    public Card generatedCard;
    private Sprite[] illustrations;

    private string[] names = { "Garrosh", "Deathwing", "Arthas", "Archimonde" };
    private string[] descriptions = { "This is description 1", "This is descripton 2", "This is description 3", "This is description 4" };

    public void GenerateCard()
    {
        generatedCard = ScriptableObject.CreateInstance<Card>();
        generatedCard.cardImage = m_gameDatabase.cardSprite;
        generatedCard.cardIllustration = illustrations[Random.Range(0, illustrations.Length)];
        generatedCard.cardName = names[Random.Range(0, names.Length)];
        generatedCard.description = descriptions[Random.Range(0, descriptions.Length)];
        generatedCard.hp = Random.Range(0, 99);
        generatedCard.mana = Random.Range(0, 20);
        generatedCard.speed = Random.Range(0, 10);
    }

    private void LoadSprites()
    {
        object[] loadedIllustrations = Resources.LoadAll("Sprites/Illustrations", typeof(Sprite));
        illustrations = new Sprite[loadedIllustrations.Length];

        for(int i = 0; i < loadedIllustrations.Length; i++)
        {
            illustrations[i] = (Sprite)loadedIllustrations[i];
        }
    }

    private void Start()
    {
        LoadSprites();
    }
}