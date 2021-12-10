using UnityEngine;

[CreateAssetMenu(fileName = "GameDatabase", menuName = "Create Game Database")]
public class GameDatabase : ScriptableObject
{
    [Header("Prefabs")]
    public GameObject cardPrefab;

    [Header("Sprites")]
    public Sprite cardSprite;
}