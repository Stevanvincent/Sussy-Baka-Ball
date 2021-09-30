using UnityEngine;

public class PlayerHit : MonoBehaviour
{

    public PlayerForward move;

    void OnCollisionEnter(Collision block)
    {
        if(block.collider.tag == "Obstacle"){
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
