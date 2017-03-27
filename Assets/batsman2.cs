using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batsman2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animation>().enabled = false;
	}
    int isf = 0;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("f"))
        {
            //DirectorPlayer.Play();
            if (isf == 0)
                GetComponent<Animation>().enabled = false;
            else
            {
               
                GetComponent<Animation>().enabled = true;
				GetComponent<Animation>().Play();
            
            }
            isf = isf ^ 1;
        }
    }
}

