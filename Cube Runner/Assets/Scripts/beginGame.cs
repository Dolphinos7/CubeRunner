using UnityEngine;
using UnityEngine.SceneManagement;

public class beginGame : MonoBehaviour {
	private void Update ()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene("level1");
        }
        if (Input.GetKey("e"))
        {
            SceneManager.LoadScene("proceduralGeneration");
        }

    }
}
