using UnityEngine;
using UnityEngine.SceneManagement;


public class Collision : MonoBehaviour
{
    public Rigidbody playerPhys;
    public MovementTesting movement;
    public bool win = false;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Debug.Log(collisionInfo.gameObject.tag == "Obstacle");
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            playerPhys.constraints = RigidbodyConstraints.FreezePosition;
            playerPhys.useGravity = false;
            playerPhys.constraints = RigidbodyConstraints.None;
            playerPhys.AddForce(0, 5, 0, ForceMode.VelocityChange);

        }
        if (collisionInfo.gameObject.tag == "End")
        {
            if (win == false)
            {
                win = true;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
    void Update()
    {
        if (FindObjectOfType<rightButton>().heldR == true && FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            FindObjectOfType<GameManager>().Restart();
        }
        if (FindObjectOfType<leftButton>().heldL == true && FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            FindObjectOfType<GameManager>().Restart();
        }
        FindObjectOfType<GameManager>().RestartOption();
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}