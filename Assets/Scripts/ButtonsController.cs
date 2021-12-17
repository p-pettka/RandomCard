using UnityEngine;
using UnityEngine.UI;

public class ButtonsController : MonoBehaviour
{
    public Button GenerateButton;
    public Button SaveButton;
    public Button ExecuteButton;

    private GameplayManager m_gameplayManager;

    private void Start()
    {
        m_gameplayManager = FindObjectOfType<GameplayManager>();

        GenerateButton.onClick.AddListener(delegate
        {
            m_gameplayManager.GenerateCard();
        });
        ExecuteButton.onClick.AddListener(delegate
        {
            m_gameplayManager.ExecuteCard();
        });
        SaveButton.onClick.AddListener(delegate
        {
            m_gameplayManager.SaveCard();
        });
    }
}
