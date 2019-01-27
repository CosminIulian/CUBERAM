using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isEnded = false;
    public GameObject completeLevelUI;

    // End the game
    public void EndGame()
    {
        if (isEnded == false) // Daca n-a mai fost finalizat atunci
        {
            isEnded = true;
            Invoke("Restart", 2f); // Apeleaza methoda Restart dupa 2sec
        }
        
    }

    // Restarteaza level-ul curent
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Afiseaza panoul LevelComplete
    public void CompleteLevel()
    {

        completeLevelUI.SetActive(true);
    }

}
