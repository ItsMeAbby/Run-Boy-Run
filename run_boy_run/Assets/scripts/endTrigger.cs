
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()

    {
        gameManager.completelevel();
    }
}
