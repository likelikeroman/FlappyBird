using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static UnityEvent OnGameOver = new();

    public static int Score;

    private static bool isGameOver = false;

    public static bool IsGameOver { get { return isGameOver; } }

    private DifficultySettings currentSettings;
    public DifficultySettings CurrentSettings { get { return currentSettings; } }

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        OnGameOver.AddListener(GameOver);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        if(DifficultyManager.instance != null)
        {
            currentSettings = DifficultyManager.instance.CurrentSettings;
        }
        else
        {
            currentSettings = new DifficultySettings(5,5,7);
        }
    }

    private void GameOver() => isGameOver = true;
}

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}
