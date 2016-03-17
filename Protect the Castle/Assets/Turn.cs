using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour
{

    private Vector2 theScale;

    // Use this for initialization
    void Start()
    {
        theScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = GetComponentInParent<Rigidbody2D>().velocity;

        if (velocity.x > 0)
        {
            theScale.x *= -1;
        }
        else
        {

        }
    }
}
