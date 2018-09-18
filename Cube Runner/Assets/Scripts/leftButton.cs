using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class leftButton : MonoBehaviour
{
    public bool heldL = false;

    public void moveLeft()
    {
        heldL = true;
    }
    public void stopMoveleft()
    {
        heldL = false;
    }







    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (heldL == true)
            FindObjectOfType<MovementTesting>().playertest.AddForce(-75.0f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
