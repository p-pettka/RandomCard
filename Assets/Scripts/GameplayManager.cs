using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public GameDatabase m_gameDatabase;

    private CardController m_cardController;
    private Card generatedCard;

    // Start is called before the first frame update
    void Start()
    {
        m_cardController = FindObjectOfType<CardController>();
        generatedCard = ScriptableObject.CreateInstance<Card>();
        generatedCard.cardIllustration = m_gameDatabase.illustration1;
        m_cardController.generatedCard = generatedCard;
        m_cardController.AssignNewCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
