using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    public float timer = 0;
    public float spawnRate;
    public List<GameObject> objects;
    public GameLogic logic;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (logic.paused == false)
        {
            timer = timer + Time.deltaTime;

            if (timer >= spawnRate)
            {
                timer = 0;
                int size = objects.Capacity;
                int item = Random.Range(0, size);
                float yLoc = Random.RandomRange(-3, 4);
                Vector3 spawnLocation = this.transform.position;
                spawnLocation.y = yLoc;
                
                GameObject obj = Instantiate(objects[item], spawnLocation, this.transform.rotation);
                ObjectMovementScript o = obj.GetComponent<ObjectMovementScript>();
                o.logic = logic;
            }

        }
    }
}
