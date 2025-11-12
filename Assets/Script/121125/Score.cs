using UnityEngine;

public class Score : MonoBehaviour
{
    public PendeteksiInput objectPendeteksiInput;
    public int score;

    public void OnEnable()
    {
        // objectPendeteksiInput.inputEvent += AddScore;
        // objectPendeteksiInput.inputEvent.AddListener(AddScore);

    }

    public void AddScore()
    {
        score = score + 1;
    }

    public void OnDisable()
    {
        // objectPendeteksiInput.inputEvent -= AddScore
        // objectPendeteksiInput.inputEvent.RemoveListener(AddScore);
    }
}
