using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0"); // seteaza scorul pe cat de mult se deplaseaza in fata
                                                      // iar "0" il transforma in integer
    }

}
