using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_blue : MonoBehaviour {

    public int scoreb = 0;
    public GameObject blue0;
    public GameObject blue1;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject player1;
    public GameObject player2;
    public GameObject bold;

    //https://answers.unity.com/questions/1012277/how-to-make-sound-play-only-once-on-trigger.html
    //lyd tutorial
    public AudioClip goal1;
    private AudioSource source;

    //https://gamedev.stackexchange.com/questions/129663/how-to-change-position-of-a-gameobject-from-another-gameobjects-script
    //Brugt til at reset object position

    // Use this for initialization
    void Start () {

        source = GetComponent<AudioSource>();

        blue0.SetActive(true);
        blue1.SetActive(false);
        blue2.SetActive(false);
        blue3.SetActive(false);

        player1 = GameObject.Find("Player 1");//This will search for the object by name;
        player1 = GameObject.FindGameObjectWithTag("player1");

        player2 = GameObject.Find("Player 2");//This will search for the object by name;
        player2 = GameObject.FindGameObjectWithTag("player2");

        bold = GameObject.Find("Bold");//This will search for the object by name;
        bold = GameObject.FindGameObjectWithTag("Ball");

    }
	
	// Update is called once per frame
	void Update () {

        print(scoreb);

        if (scoreb == 0)
        {
            blue0.SetActive(true);
            blue1.SetActive(false);
            blue2.SetActive(false);
            blue3.SetActive(false);
        }
        else if (scoreb == 1)
        {
            blue0.SetActive(false);
            blue1.SetActive(true);
            blue2.SetActive(false);
            blue3.SetActive(false);
        }
        else if (scoreb == 2)
        {
            blue0.SetActive(false);
            blue1.SetActive(false);
            blue2.SetActive(true);
            blue3.SetActive(false);
        }
        else if (scoreb == 3)
        {
            blue0.SetActive(false);
            blue1.SetActive(false);
            blue2.SetActive(false);
            blue3.SetActive(true);
        }
    }


    //tak laurits
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            scoreb = scoreb + 1;
            print(scoreb);
            player1.transform.position = new Vector3(24, 0, 0);
            player2.transform.position = new Vector3(-24, 0, 0);
            bold.transform.position = new Vector3(0, 0, 0);
            //source.clip = goal1;
            //source.Play();
            source.PlayOneShot (goal1,1);
        }
    }
}
