using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameplayManager : MonoBehaviour
{
    private CardController m_cardController;
    private CardGenerator m_cardGenerator;
    private PlayerController m_playerController;

    // Start is called before the first frame update

    public void GenerateCard()
    {
        m_cardGenerator.CreateCard();
        m_cardController.currentCard = m_cardGenerator.generatedCard;
        m_cardController.UpdateCard();
    }

    public void ExecuteCard()
    {
        m_playerController.playerHp = m_cardController.currentCard.hp;
        m_playerController.playerMana = m_cardController.currentCard.mana;
        m_playerController.playerSpeed = m_cardController.currentCard.speed;

        m_playerController.UpdatePlayerStats();
        GenerateCard();
    }

    public void SaveCard()
    {
        string prefabsLocation = "Assets/Prefabs/" + "SavedCard" + ".prefab";
        prefabsLocation = AssetDatabase.GenerateUniqueAssetPath(prefabsLocation);
        PrefabUtility.SaveAsPrefabAssetAndConnect(m_cardController.gameObject, prefabsLocation, InteractionMode.UserAction);
    }

    void Start()
    {
        m_cardController = FindObjectOfType<CardController>();
        m_cardGenerator = FindObjectOfType<CardGenerator>();
        m_playerController = FindObjectOfType<PlayerController>();
    }
}
