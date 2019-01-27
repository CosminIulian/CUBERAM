using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; // referinta la componenta Rigidbody numita "rb"
   
    // Update is called once per frame
    // Am modificat numele methodei din "Update" in "FixedUpdate", deoarece folosesc methode de miscare fizica
    void FixedUpdate()
    {

        rb.AddForce(0, 0, 4000 * Time.deltaTime); // impinge fortat playerul in fata per frame(Time.deltaTime)

        if (Input.GetKey("d")) // daca tasta introdusa este "d" atunci impinge fortat la dreapta
        {
            rb.AddForce(100 * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }

        else if (Input.GetKey("a")) // altfel daca tasta introdusa este "a" atunci impinge fortat spre stanga
        {
            rb.AddForce(-100 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(rb.position.y < -1f) // daca cubul cade jos atunci end game
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
