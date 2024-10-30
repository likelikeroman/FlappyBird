using UnityEngine;

public class DifficultySettings : MonoBehaviour
{
    [SerializeField] private float birdSpeed;
    [SerializeField] private float pipeSpeed;
    [SerializeField] private float pipeGap;

    public float BirdSpeed { get { return birdSpeed; } }
    public float PipeSpeed { get { return pipeSpeed; } }
    public float PipeGap { get { return pipeGap; } }

    public DifficultySettings(float birdSpeed, float pipeSpeed, float pipeGap)
    {
        this.birdSpeed = birdSpeed;
        this.pipeSpeed = pipeSpeed;
        this.pipeGap = pipeGap;
    }
}
