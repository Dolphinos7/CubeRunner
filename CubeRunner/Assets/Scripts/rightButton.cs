using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rightButton : MonoBehaviour {
    public bool heldR = false;

    public void moveRight()
    {
        heldR = true;   
    }
    public void stopMoveR()
    {
        heldR = false;
    }

	void Update ()
    {
        if(heldR==true)
        FindObjectOfType<MovementTesting>().playertest.AddForce(75.0f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
