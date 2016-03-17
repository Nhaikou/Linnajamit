using UnityEngine;
using System.Collections;

public class DankaBomb : MonoBehaviour {

    public float radius;
    public float strength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D (Collision2D collision) {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D collider in colliders) {
            Rigidbody2D colbody = collider.GetComponent<Rigidbody2D>();
            Transform coltrans = collider.GetComponent<Transform>();

            if (colbody && coltrans)
            {    
                float distance = Vector2.Distance(transform.position, coltrans.position);
                float force = (1 - (distance / radius)) * strength;

                if (force > 0)
                {
                    Vector2 direction = coltrans.position - transform.position;
                    direction.Normalize();

                    colbody.WakeUp();
                    colbody.AddForce(direction * force, ForceMode2D.Impulse);

                    if (colbody.CompareTag("Brick"))
                    {
                        Object.FindObjectOfType<Text>().IsHit();
                    }
                }
            }
        }

        Destroy(gameObject);
    }

}
