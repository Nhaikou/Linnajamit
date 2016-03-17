using UnityEngine;
using System.Collections;
public class PathedProjectile : MonoBehaviour
{
    private Transform pDestination;
    private float pSpeed;

    public void Initialize(Transform destination, float speed)
    {
        pDestination = destination;
        pSpeed = speed;
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pDestination.position, Time.deltaTime * pSpeed);

        var distanceSquared = (pDestination.transform.position - transform.position).sqrMagnitude;
        if (distanceSquared > .01f * 0.1f)
        {
            return;
        }

        Object.FindObjectOfType<TaikaMiekka>().NextDrop();

        Destroy(gameObject);
    }

}

