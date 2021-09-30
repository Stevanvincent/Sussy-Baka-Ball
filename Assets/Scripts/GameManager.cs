using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool Ended = false;
    public GameObject panel;

    public void EndLevel()
    {
        panel.SetActive(true);
    }
    
    public void EndGame()
    {
        if(Ended == false)
        {
            Ended = true;
            Invoke("Restart", 1f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
