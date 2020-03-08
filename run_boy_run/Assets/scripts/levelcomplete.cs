
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelcomplete : MonoBehaviour
{
    public void LNEXTLEVEL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
