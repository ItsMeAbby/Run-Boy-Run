using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    public Animator anim;
    public playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "bottle")
        {
            Debug.Log("j");
            movement.enabled = false;
            anim.Play("drink");
            FindObjectOfType<GameManager>().endgame();

        }
    }
   
   
}
