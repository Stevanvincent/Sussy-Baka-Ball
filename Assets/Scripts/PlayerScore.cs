using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Transform score;
    public Text scoreNumber;

    void Update()
    {
        scoreNumber.text = score.position.z.ToString("0");
    }
}
