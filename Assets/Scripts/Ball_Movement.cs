using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ball_Movement : MonoBehaviour {
	public float BallSpeed;
	public Rigidbody2D Ball;
	public Rigidbody2D MainCamera;
    public GameObject star;
    public Camera perspectiveCamera;
    public static int lives=3;
    public GameObject startPosition;
	private Vector2 BallMovement;
	private bool isFalling = false;
    private AudioSource jumpSound;
    public Text win;
    // Use this for initialization

    void Awake()
    {

    }
    void Start () {

        perspectiveCamera.gameObject.SetActive(false);
        jumpSound = GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {
        BallMovement = new Vector2(Input.GetAxis("Horizontal") * BallSpeed, 0);
        if (Input.GetKeyDown(KeyCode.Q))
        {
           perspectiveCamera.gameObject.SetActive(true);
           
        }
        if (Input.GetKey(KeyCode.Q))
        {
            BallMovement = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
           perspectiveCamera.gameObject.SetActive(false);
        }
		Ball.AddForce (BallMovement);

		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
			MainCamera.MovePosition(new Vector2(Ball.position.x,Ball.position.y + Input.GetAxis ("Vertical")*3));
	    	}
		else {
			MainCamera.MovePosition(Ball.position);
		}

		if (Input.GetKeyDown (KeyCode.Space) == true && isFalling == false ) {
			Ball.AddForce(new Vector2(0,1000));
            jumpSound.Play();

		}
		isFalling = true;
	}
    void OnCollisionStay2D(Collision2D otherObj)
    {
			isFalling = false;
		}
    void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag == "Trap")
        {
            Debug.Log("Collided and died");
            lives--;
            Application.LoadLevel(Application.loadedLevel);

            if (lives<0)
            {

                win.text = "YOU LOSE";
                lives = 3;
                Application.LoadLevel(0);
            }
            Debug.Log("Number of lives left = " + lives);
        }
    }

    IEnumerator OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Chest")
        {
            win.text = "YOU Win!";
            yield return new WaitForSeconds(1);
            Application.LoadLevel(0);
        }

    }
}


