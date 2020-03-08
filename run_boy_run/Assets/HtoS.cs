using UnityEngine;
using UnityEngine.SceneManagement;

public class HtoS : MonoBehaviour
{

    public void Htos()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }
    public void stoH()
    {
        SceneManager.LoadScene("HELP");

    }
    public void Ctos()
    {
        SceneManager.LoadScene(0);

    }
    public void stoC()
    {
        SceneManager.LoadScene("CREDITS");

    }

    public void NEXTLEVEL()
    {
        if(SceneManager.GetActiveScene().name== "Level2-AJ")
        {
            SceneManager.LoadScene(0);
        }
        else
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void character()
    {
        SceneManager.LoadScene("character selection");

    }

    public void AJ()
    {
        SceneManager.LoadScene(1);
    }
    public void AB()
    {
        SceneManager.LoadScene(3);
    }

}
