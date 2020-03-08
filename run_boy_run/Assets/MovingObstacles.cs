using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    public int speed = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x<=-2.1)
        {
            speed = 2;
        }
        if (transform.position.x >= 2)
        {
            speed = -2;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
