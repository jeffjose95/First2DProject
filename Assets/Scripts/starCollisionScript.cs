using UnityEngine;
using System.Collections;

public class starCollisionScript : MonoBehaviour {
    public GameObject Player;
    public GameObject spawnPosition;
    public Collision2D starCollision;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Player" )
        {
            Debug.Log("Triggered");
            otherObj.transform.position = spawnPosition.transform.position;
        
        }
    }

    void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            otherObj.transform.position = spawnPosition.transform.position;
        
        }
    }

    }
