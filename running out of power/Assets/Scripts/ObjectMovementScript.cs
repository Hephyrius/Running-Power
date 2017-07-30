using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementScript : MonoBehaviour {

    public float speed = -0.1f;
    public bool isDestroyable = true;
    public GameLogic logic;

    // Use this for initialization
    void Start()
    {

    }



    void OnTriggerEnter2D(Collider2D coll)
    {
        if (logic.paused == false)
        {
            if (isDestroyable == true)
            {
                Debug.Log("collision");
                Destroy(gameObject);
            }
            if (isDestroyable == false)
            {
                if (coll.gameObject.tag == "Edge")
                {
                    Debug.Log("collision");
                    Destroy(gameObject);
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (logic.paused == false)
        {
            this.transform.Translate(transform.right * speed);
        }
    }
}
