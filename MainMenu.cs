using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MainMenu : MonoBehaviour {

    private GUIStyle guiStyle = new GUIStyle();

    private void OnGUI()
    {

        guiStyle.fontSize = 90;
        guiStyle.normal.textColor = Color.white;

        GUI.Label(new Rect(65, 100, 370, 100), "Runaway Planet", guiStyle);

        if (GUI.Button(new Rect(430, 300, 150, 40), "Start New Game"))
            //Application.LoadLevel("RunawayPlanet2");
		    UnityEngine.SceneManagement.SceneManager.LoadScene ("MyRPScene");

        if (GUI.Button(new Rect(430, 350, 150, 40), "Instructions"))
        {
            
        }
            //Application.LoadLevel("TestCode");
		    //UnityEngine.SceneManagement.SceneManager.LoadScene ("TestCode");
    }
}
