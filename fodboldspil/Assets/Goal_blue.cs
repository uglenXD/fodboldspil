using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_blue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //tak laurits
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            print("Red is epic");
        }
    }
}
