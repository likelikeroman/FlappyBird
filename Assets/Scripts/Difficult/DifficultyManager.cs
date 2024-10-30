using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager instance;

    [SerializeField] private DifficultySettings easySettings;
    [SerializeField] private DifficultySettings mediumSettings;
    [SerializeField] private DifficultySettings hardSettings;

    public DifficultySettings CurrentSettings { get; private set; }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                CurrentSettings = easySettings;
                break;
            case Difficulty.Medium:
                CurrentSettings = mediumSettings;
                break;
            case Difficulty.Hard:
                CurrentSettings = hardSettings;
                break;
        }
    }
}
