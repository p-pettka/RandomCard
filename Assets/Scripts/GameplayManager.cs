using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private CardController m_cardController;
    private CardGenerator m_cardGenerator;

    // Start is called before the first frame update

    private void GenerateCard()
    {
        m_cardGenerator.CreateCard();
        m_cardController.currentCard = m_cardGenerator.generatedCard;
        m_cardController.UpdateCard();
    }

    void Start()
    {
        m_cardController = FindObjectOfType<CardController>();
        m_cardGenerator = FindObjectOfType<CardGenerator>();

        GenerateCard();
    }
}
