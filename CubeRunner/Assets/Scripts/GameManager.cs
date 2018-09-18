using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public bool gameHasEnded = false;
    public void finalScore()
    {

    }
    public void EndGame()
    {
        FindObjectOfType<MovementTesting>().enabled = false;
        FindObjectOfType<rightButton>().enabled = false;
        FindObjectOfType<leftButton>().enabled = false;
        gameHasEnded = true;
    }
    public void RestartOption()
    {
        if (gameHasEnded == true)
        {
            if (Input.GetKey("r"))
            {
                Restart();
            }
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void titleScreen()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
