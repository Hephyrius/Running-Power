using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine("loadGame");


    }


    IEnumerator loadGame()
    {


        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game");
    }
}
