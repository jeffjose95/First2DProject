using UnityEngine;
using System.Collections;

public class end_script : MonoBehaviour {
	public Rigidbody2D end;
	public Rigidbody2D Ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D collided){
		print("You Win");
	}
}
