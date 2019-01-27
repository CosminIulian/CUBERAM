using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public GameManager gameManager; // referinta la obiectul GameManager

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
