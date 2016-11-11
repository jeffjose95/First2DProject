using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadScene(int level)
    {
        Application.LoadLevel(level);
    }

    public void closeGame()
    {
        Application.Quit();
    }
}
