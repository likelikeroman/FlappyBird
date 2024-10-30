using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class BirdController : MonoBehaviour
{
    [SerializeField] private float force = 1;

    private Rigidbody2D birdRB;

    private void Awake()
    {
        birdRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.touchCount != 0) && !GameManager.IsGameOver)
        {
            birdRB.velocity = Vector3.zero;
            birdRB.AddForce(Vector3.up * force, ForceMode2D.Impulse);
        }
        else if (GameManager.IsGameOver)
        {
            Destroy(this);
        }
    }
}
