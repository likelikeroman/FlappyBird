using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{
    [SerializeField] private Button easyButton;
    [SerializeField] private Button mediumButton;
    [SerializeField] private Button hardButton;

    public void Awake()
    {
        easyButton.onClick.AddListener(() => SetDifficultyAndStartGame(Difficulty.Easy));
        mediumButton.onClick.AddListener(() => SetDifficultyAndStartGame(Difficulty.Medium));
        hardButton.onClick.AddListener(() => SetDifficultyAndStartGame(Difficulty.Hard));
    }

    public void SetDifficultyAndStartGame(Difficulty difficulty)
    {
        DifficultyManager.instance.SetDifficulty(difficulty);
        SceneManager.LoadScene("GameScene");
    }
}
