using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVars : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool hasStarted = false;
    public static int score = 0;
    public static int highScore = 0;

    public void ResetScene()
    {
        gameOver = false;
        hasStarted= false;
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
