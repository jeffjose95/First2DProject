using UnityEngine;
using System.Collections;

public class fullscreenView : MonoBehaviour {
    public GameObject player;
    public float distanceFromPlayer;
    public Rigidbody2D cameraPosition;
	// Use this for initialization
	void Start () {

        cameraPosition = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        cameraPosition.transform.position = new Vector3(player.transform.position.x,player.transform.position.y,distanceFromPlayer);
	}
}
