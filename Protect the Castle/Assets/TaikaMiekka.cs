using UnityEngine;
using System.Collections;

public class TaikaMiekka : MonoBehaviour {

    public float leftPoint;
    public float rightPoint;
    public float verticalPoint;

    public float dropInterval;

    public GameObject dankaPrefab;

    private bool dropping = false;
    private float lastDrop = 0.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (dropping && (Time.time - lastDrop) > dropInterval)
        {
            GameObject newDanka = Instantiate(dankaPrefab);

            newDanka.transform.Translate(Random.Range(leftPoint, rightPoint), verticalPoint, 0);

            dropping = false;
        }
	}

    public void NextDrop ()
    {
        dropping = true;
        lastDrop = Time.time;
    }
}
