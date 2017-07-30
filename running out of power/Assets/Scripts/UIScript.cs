using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text energyText;
    public PlayerScript pl;
    public Text timerText;
    public Text healthText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        energyText.text = pl.energy.ToString("f2") + " power";
        timerText.text = pl.survivalTimer.ToString("f2") + " s";
        healthText.text = pl.health.ToString("f2") + " HP";
    }
}
