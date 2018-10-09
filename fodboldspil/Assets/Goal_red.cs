using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_red : MonoBehaviour {


   public int score = 0;
   public GameObject red0;
   public GameObject red1;
   public GameObject red2;
   public GameObject red3;

	// Use this for initialization
	void Start () {

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


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            score = score + 1;
            print(score);
        }
    }

}
