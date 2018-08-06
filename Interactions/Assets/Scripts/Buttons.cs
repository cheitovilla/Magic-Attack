using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LinkStrat() {
        Time.timeScale = 1;// pa que empiece con velocidad normal
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame(){
       // SceneManager.LoadScene("Menu");
        Application.Quit();
    }

    public void BackScene() {
        SceneManager.LoadScene("Menu");
    }
    

}
