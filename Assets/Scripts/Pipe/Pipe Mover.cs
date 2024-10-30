using UnityEngine;

public class PipeMover : MonoBehaviour
{
    private float speed = 1.0f;

    private void Start()
    {
        if (GameManager.instance != null)
        {
            speed = GameManager.instance.CurrentSettings.PipeSpeed;

        }
    }

    private void Update()
    {
        if (!GameManager.IsGameOver)
        { 
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            Destroy(this);
        }
    }  
}
