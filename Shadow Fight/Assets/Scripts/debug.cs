using UnityEngine;

public class debug : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Untagged")
        Debug.Log(collision.gameObject.tag);
    }
}
