using UnityEngine;

public class LevelComplete : MonoBehaviour
{

    public GameManager gameManage;

    void OnTriggerEnter() 
    {
        gameManage.EndLevel();
    }

}