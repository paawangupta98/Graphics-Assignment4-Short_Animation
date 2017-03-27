using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animator>().enabled = false;
	}
    int isf = 0;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("m"))
        {
            //DirectorPlayer.Play();
            if (isf == 0)
                GetComponent<Animator>().enabled = false;
            else
            {
               
                GetComponent<Animator>().enabled = true;
               
            }
            isf = isf ^ 1;
        }
    }
}
