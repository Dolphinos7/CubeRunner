using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leftButtonStart : MonoBehaviour
{
    public void startlevel1()
    {
        SceneManager.LoadScene("level1");
    }
}
