using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endQuit : MonoBehaviour {
    public Button quitText;
    public Canvas endMenu;

	// Use this for initialization
	public void Start () {
        quitText = quitText.GetComponent<Button>();
        endMenu = endMenu.GetComponent<Canvas>();
        Cursor.visible = true;
	}
	
	public void pressquit()
    {
        Application.Quit();
    }
	
}
