using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour {

    public PlayerScript pl;
    public Text ScoreText;

	// Use this for initialization
	void Start () {
		
	}

    public void restartLevel()
    {
        SceneManager.LoadScene("Game");
    }


    public void Hephyrius()
    {
        Application.OpenURL("http://www.Hephyrius.com/");
    }

    // Update is called once per frame
    void Update () {

        ScoreText.text = "Survival Time: " + pl.survivalTimer.ToString("f2") +"\n";
        ScoreText.text = ScoreText.text + "Total Power Collected: " + pl.totalEnergy + "\n";
        float score = pl.totalEnergy * pl.survivalTimer;
        ScoreText.text = ScoreText.text + "Total Score: " + score.ToString("f2");


    }
}
