using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float energy = 5.0f;
    public Rigidbody2D rb;
    public float jumpforce = 5f;
    public float energyCost = 0.1f;

    public float energyTimer = 0;
    public float health = 100;
    public float survivalTimer;

    public GameLogic logic;

    public GameObject gameoverscreen;

    public float totalEnergy = 0;

    public SoundManager sound;

    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (logic.paused == false)
        {
            if (coll.gameObject.tag == "Energy")
            {
                energy = energy + 5;
                totalEnergy = totalEnergy + 5;
                sound.playSound3();

            }
            if (coll.gameObject.tag == "Enemy")
            {
                health = health - 30;
                checkHealth();
                sound.playSound1();
            }
            if (coll.gameObject.tag == "Health")
            {
                health = health + 10;
                checkHealth();
                sound.playSound5();
            }
            if (coll.gameObject.tag == "Negative Energy")
            {
                energy = energy - 10;
                checkEnergy();
                sound.playSound7();
            }
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (logic.paused == false)
        {
            if (coll.gameObject.tag == "PowerArea")
            {
                energy = energy + 1;
                totalEnergy = totalEnergy + 1;
                sound.playSound3();
            }
            if (coll.gameObject.tag == "PowerDownArea")
            {
                energy = energy - 1;
                checkEnergy();
                sound.playSound7();
            }
        }
    }

    void checkHealth()
    {
        if (health <= 0)
        {
            health = 0;
            logic.paused = true;
            gameoverscreen.SetActive(true);
            sound.playSound8();
        }

        if (health >= 100)
        {
            health = 100;
        }
    }

    void checkEnergy()
    {
        if (energy < 0)
        {
            energy = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.paused == false)
        {
            survivalTimer = survivalTimer + Time.deltaTime;
            energyTimer = energyTimer + Time.deltaTime;

            if (energyTimer >= 1)
            {
                energyTimer = 0;
                if (energy / 10 > 0.5f)
                {
                    energy = energy - (energy / 10);
                }
                else
                {
                    energy = energy - 0.5f;
                }

            }


            if (Input.GetButton("Fire1"))
            {
                if (energy >= energyCost)
                {
                    sound.playSound2();
                    Vector2 force = new Vector2(0, jumpforce+(energy/10));
                    rb.AddForce(force, ForceMode2D.Force);
                    energy = energy - 0.1f;
                }
            }

            if(energy <= 0)
            {
                health = health - 0.2f;
                checkHealth();
            }

            checkEnergy();


            if (this.transform.position.x != -6)
            {
                Vector3 position = this.transform.position;
                position.x = -6;
                this.transform.position = position;
            }

        }
    }
}
