using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugS : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);    
    }
}
