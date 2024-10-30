using UnityEngine;

public class PipeGapRandomizer : MonoBehaviour
{
    [SerializeField] private GameObject _lowerPipe;
    [SerializeField] private GameObject _upperPipe;

    [SerializeField] private float _minHeight = -5.0f;
    [SerializeField] private float _maxHeight = -7.1f;
    [SerializeField] private float _minGap = 10.0f;
    [SerializeField] private float _maxGap = 14.0f;

    private void Awake()
    {
        RandomGap();
    }

    private void RandomGap()
    {
        float lowerPipeHeight = Random.Range(_minHeight, _maxHeight);
        float gap = Random.Range(_minGap, _maxGap);

        Vector3 lowerPipePosition = new Vector3(transform.position.x, lowerPipeHeight, 0);
        _lowerPipe.transform.position = lowerPipePosition;

        Vector3 upperPipePosition = new Vector3(transform.position.x, lowerPipeHeight + _lowerPipe.GetComponent<Renderer>().bounds.size.y + gap, 0);
        _upperPipe.transform.position = upperPipePosition;
    }
}