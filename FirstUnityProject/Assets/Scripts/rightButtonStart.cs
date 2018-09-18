using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class rightButtonStart : MonoBehaviour
{
    public void startEndlessTap()
    {
        SceneManager.LoadScene("proceduralGeneration");
    }
}