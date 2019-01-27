using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // Se executa cand exista o coliziune cu un obiect, 
    // parametrul collision returneaza obiectul cu care a avut coliziunea
    void OnCollisionEnter(Collision collisionInfo)
    {
  
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Dezactiveaza miscarea playerului
            FindObjectOfType<GameManager>().EndGame(); // Apeleaza functia EndGame din clasa GameManager
        }      
    }

}
