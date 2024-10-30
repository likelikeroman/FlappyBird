using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnCooldown;

    private void Start()
    {
        StartCoroutine(SpawnPipeCoroutine());
    }

    private IEnumerator SpawnPipeCoroutine()
    {
        while (!GameManager.IsGameOver)
        {
            SpawnPipe();
            yield return new WaitForSeconds(spawnCooldown);
        }
    }
    
    private void SpawnPipe()
    {
        Vector3 spawnPoisition = new Vector3(transform.position.x, 0f, 0f);
        Instantiate(pipePrefab, spawnPoisition, Quaternion.identity);
    }
}