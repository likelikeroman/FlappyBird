using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public static UnityEvent OnPauseEnable = new UnityEvent();
    public static UnityEvent OnPauseDisable = new UnityEvent();
    
    [SerializeField] private TextMeshProUGUI scoreLebel;
    [SerializeField] private GameObject pauseMenuObject;
    [SerializeField] private GameObject gameOverPanel;

    private void Awake()
    {
        pauseMenuObject.SetActive(false);
        gameOverPanel.SetActive(false);

        GameManager.OnGameOver.AddListener(ActivateGameOverPanel);
        
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void UpdateLebel()
    {
        scoreLebel.text = "Score:" + GameManager.Score;
    }

    public void OnPauseMenu()
    {
        OnPauseEnable?.Invoke();
        pauseMenuObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void OffPauseMenu()
    {
        OnPauseDisable?.Invoke();
        pauseMenuObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMenu()
    {
       /* Destroy(DifficultyManager.instance.gameObject); */
        SceneManager.LoadScene("Menu");
    }

    private void ActivateGameOverPanel() => gameOverPanel.SetActive(true);
}