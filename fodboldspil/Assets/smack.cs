using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smack : MonoBehaviour {

    public AudioClip bang;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "player2")
        {
            //spiller lyd af mål
            source.PlayOneShot(bang, 1);
        }
    }
}
