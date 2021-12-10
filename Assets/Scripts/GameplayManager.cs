using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private CardController m_cardController;
    private CardGenerator m_cardGenerator;
    private Card generatedCard;

    // Start is called before the first frame update

    private void UpdateCard()
    {
        m_cardController.currentCard = generatedCard;
        m_cardController.AssignNewCard();
    }

    void Start()
    {
        m_cardController = FindObjectOfType<CardController>();
        m_cardGenerator = FindObjectOfType<CardGenerator>();

        m_cardGenerator.GenerateCard();
        generatedCard = m_cardGenerator.generatedCard;
        UpdateCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
