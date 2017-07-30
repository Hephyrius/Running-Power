using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderScript : MonoBehaviour {

    public PlayerScript pl;
    public SpriteRenderer sprite;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Color tmp = sprite.color;
        if (pl.energy < 2)
        {
            tmp.a = 0.9f;
            sprite.color = tmp;
        }
        else if (pl.energy < 5)
        {
            tmp.a = 0.75f;
            sprite.color = tmp;
        }
        else if (pl.energy < 10)
        {
            tmp.a = 0.5f;
            sprite.color = tmp;
        }
        else if (pl.energy < 20)
        {
            tmp.a = 0.25f;
            sprite.color = tmp;
        }
        else if (pl.energy < 30)
        {
            tmp.a = 0.1f;
            sprite.color = tmp;
        }
        else
        {
            sprite.color = new Color(0, 0, 0, 0f);
        }
	}
}
