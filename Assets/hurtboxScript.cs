using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtboxScript : MonoBehaviour
{
    public UIfunctions uiFunctions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            uiFunctions.AddScore();
        }
    }

}
