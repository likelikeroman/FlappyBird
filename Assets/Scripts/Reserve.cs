using UnityEngine;
using UnityEngine.SceneManagement;

public class Reserve: MonoBehaviour
{
 
    public void LoadScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
