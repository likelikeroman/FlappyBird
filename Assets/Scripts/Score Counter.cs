using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Score += 1;
            UIController.instance.UpdateLebel();
        }
    }
}