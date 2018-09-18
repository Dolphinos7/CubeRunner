using UnityEngine;

public class MovementTesting : MonoBehaviour {
    public Rigidbody playertest;
    public float ForwardForce = 500f;
    public float SideForce = 200f;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (playertest.position.y < .99f)
        {
            FindObjectOfType<GameManager>().EndGame();
            playertest.constraints = RigidbodyConstraints.FreezePosition;
            playertest.useGravity = false;
            playertest.constraints = RigidbodyConstraints.None;
            playertest.AddForce(0, 5, 0, ForceMode.VelocityChange);
        }
         playertest.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            playertest.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            playertest.AddForce(-SideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}