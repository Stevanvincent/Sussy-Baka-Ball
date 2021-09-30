using UnityEngine;

public class PlayerForward : MonoBehaviour
{
    public Rigidbody rb;
    public float forWard = 2000f;
    public float direction = 200f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forWard * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-direction * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(direction * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -5.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
