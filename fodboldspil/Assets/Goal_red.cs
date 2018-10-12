using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_red : MonoBehaviour {


   public int score = 0;
   public GameObject red0;
   public GameObject red1;
   public GameObject red2;
   public GameObject red3;
   public GameObject player1;
   public GameObject player2;
   public GameObject bold;

    //https://answers.unity.com/questions/1012277/how-to-make-sound-play-only-once-on-trigger.html
    //lyd tutorial
    public AudioClip goal1;
   private AudioSource source;

    // Use this for initialization
    void Start () {

        player1 = GameObject.Find("Player 1");//This will search for the object by name;
        player1 = GameObject.FindGameObjectWithTag("player1");

        player2 = GameObject.Find("Player 2");//This will search for the object by name;
        player2 = GameObject.FindGameObjectWithTag("player2");

        bold = GameObject.Find("Bold");//This will search for the object by name;
        bold = GameObject.FindGameObjectWithTag("Ball");

        source = GetComponent<AudioSource>();

        red0.SetActive(true);
        red1.SetActive(false);
        red2.SetActive(false);
        red3.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        print(score);

        if (score == 0)
        {
            red0.SetActive(true);
            red1.SetActive(false);
            red2.SetActive(false);
            red3.SetActive(false);
        }
        else if (score == 1)
        {
            red0.SetActive(false);
            red1.SetActive(true);
            red2.SetActive(false);
            red3.SetActive(false);
        }
        else if (score == 2)
        {
            red0.SetActive(false);
            red1.SetActive(false);
            red2.SetActive(true);
            red3.SetActive(false);
        }
        else if (score == 3)
        {
            red0.SetActive(false);
            red1.SetActive(false);
            red2.SetActive(false);
            red3.SetActive(true);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            player1.transform.position = new Vector3(24, 0, 0);
            player2.transform.position = new Vector3(-24, 0, 0);
            bold.transform.position = new Vector3(0, 0, 0);

            score = score + 1;
            print(score);
            source.PlayOneShot(goal1, 1);
        }
    }

}
