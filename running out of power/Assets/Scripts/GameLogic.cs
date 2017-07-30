using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public bool paused;
    public bool firstClick;
    public GameObject clickStart;
    public SoundManager sound;

    // Use this for initialization
    void Start () {
        paused = true;
        firstClick = true;

    }
	
	// Update is called once per frame
	void Update () {
		
        if(firstClick == true)
        {
            if (Input.GetButtonDown("Fire1")) { 
                paused = false;
                firstClick = false;
                sound.playSound2();
                clickStart.SetActive(false);
            }
        }


	}
}
