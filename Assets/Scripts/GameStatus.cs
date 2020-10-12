using UnityEngine;

public class GameStatus : MonoBehaviour
{

    [SerializeField] private int score = 0;
    [SerializeField] private int health = 3;
    [SerializeField] private int level = 1;
    
    private void Awake()
    {
        int gameStatusesCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusesCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int Score
    {
        get => score;
        set => score = value;
    }

    public int Health
    {
        get => health;
        set => health = value;
    }

    public int Level
    {
        get => level;
        set => level = value;
    }
}