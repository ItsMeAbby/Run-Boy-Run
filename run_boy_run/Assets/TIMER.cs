using UnityEngine.UI;
using UnityEngine;

public class TIMER : MonoBehaviour
{
    public Text text;
    public Transform X;
    float timer=0f;
    
    void Update()
    {
        if(X.transform.position.z<-2)
        {
            timer += Time.deltaTime;

            int seconds = (int)(timer % 60);

            int minutes = (int)(timer / 60) % 60;
            int hours = (int)(timer / 3600) % 24;
            int ms = (int)(timer * 100) % 100;

            string time = string.Format("{0:0}:{1:00}:{2:00}:{3:00}", hours, minutes, seconds, ms);
            text.text = time;

        }
    }
}
