using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    float restartdelay = 2f;
    public GameObject completelevelui;

    public void completelevel()
    {
        Debug.Log("level won");
        completelevelui.SetActive(true);
    }
    public void endgame()
    {
        if (gamehasended==false)
        {
            gamehasended = true;
            Debug.Log("gave over");
            Invoke("restart", restartdelay);
        }
    }
    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
