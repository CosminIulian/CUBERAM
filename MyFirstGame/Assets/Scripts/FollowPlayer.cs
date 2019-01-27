using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // referinta la componenta Transform  a elementului Player
    public Vector3 offset; // vector care ma ajuta la modificarea pozitiei fata de Player, 
                          //  altfel vine centrat pe el

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; // urmareste playerul din spate, pe scurt
    }

}
