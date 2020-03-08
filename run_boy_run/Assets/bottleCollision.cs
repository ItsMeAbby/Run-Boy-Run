using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleCollision : MonoBehaviour
{
    public playermovement movement;
    public Animator anim;
    public void OnTriggerEnter(Collider player)
    {
        if (player.name == "aj")
        {
            Debug.Log("jj");
            movement.enabled = false;
            anim.SetBool("drink", true);
            GameObject.Destroy(gameObject);
        }
    }
}
