using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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

        //https://gamedev.stackexchange.com/questions/129663/how-to-change-position-of-a-gameobject-from-another-gameobjects-script
        //Brugt til at reset object position

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

        //tjekker scoren til at vise den korrekte sprite
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

            //resetter spil når vi har fundet en vinder
            Scene loadedLevel = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadedLevel.buildIndex);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            //når der er scoret resetter placeringen af spillerne og bold
            player1.transform.position = new Vector3(24, 0, 0);
            player2.transform.position = new Vector3(-24, 0, 0);
            bold.transform.position = new Vector3(0, 0, 0);


            //+1 til scoren, sådan sprite kan skifte
            score = score + 1;

            print(score);

            //spiller lyd af mål
            source.PlayOneShot(goal1, 1);
        }
    }

}
