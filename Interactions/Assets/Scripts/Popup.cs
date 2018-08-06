using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Popup : MonoBehaviour {

    public GameObject LosePopup;
    public GameObject WinPopup;
    public Text FinalGold;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("perdí");
            LosePopup.SetActive(true);
            Cursor.visible = true; //Activa cursor
            Time.timeScale = 0; // PONE PAUSE
        }

        if (other.tag == "Goal")
        {
            Debug.Log("ganeeee");
            WinPopup.SetActive(true);
            Cursor.visible = true;
            FinalGold.text = "You collected "+ GetComponent<Collection>().gold + " coins";
            Time.timeScale = 0;
        }


    }
}
