using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D myRigidBody;

    [SerializeField]
    private float movementSpeed;

	// Use this for initialization
	void Start ()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");

        handleMovement(horizontal);
	}

    private void handleMovement(float horizontal)
    {
        myRigidBody.velocity = new Vector2(horizontal * movementSpeed, myRigidBody.velocity.y);
    }
}
