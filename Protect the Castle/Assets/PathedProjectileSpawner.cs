using UnityEngine;
using System.Collections;

public class PathedProjectileSpawner : MonoBehaviour 
{

    public Transform Destination;
    public PathedProjectile Projectile;

    public float Speed;
    public float FireDelay;

    private float nextShotInSeconds;

	// Use this for initialization
	public void Start () {

        nextShotInSeconds = FireDelay;
	
    }
	
	// Update is called once per frame
	public void Update () 
    {
        if ((nextShotInSeconds  -= Time.deltaTime) > 0)
        {
            return;
        }

        nextShotInSeconds = FireDelay;
        var projectile = (PathedProjectile) Instantiate(Projectile, transform.position, transform.rotation);
        projectile.Initialize(Destination, Speed);

        if (FireDelay >= 0.5f)
        {
            FireDelay -= 0.01f;
        }

    }

    public void OnDrawGizmos()
    {
        if (Destination == null)
        {
            return;
        }

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, Destination.position);
    }
}
