using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
         GameManager.OnGameOver.Invoke();
    }
}
