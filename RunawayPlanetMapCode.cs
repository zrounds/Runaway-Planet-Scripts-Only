using UnityEngine;
using System.Collections;

public class RunawayPlanetMapCode : MonoBehaviour {

    private void OnGUI()
    {
        if (GUI.Button(new Rect(15, 15, 150, 40), "Back to Main Menu"))
            //Application.LoadLevel("mainmenu");
			UnityEngine.SceneManagement.SceneManager.LoadScene ("mainmenu");
        
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
