using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rotationfloatation : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        int a = Random.Range(0, 1);

        if (a == 1)
            transform.Rotate(0, 5, 0);
        if (a == 0 )
            transform.Rotate(0, -5, 0);

    }
}
