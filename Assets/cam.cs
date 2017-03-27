using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class cam : MonoBehaviour {
Stopwatch stopwatch = Stopwatch.StartNew();
	// Use this for initialization
	void Start () {
		GetComponent<Animator>().enabled = false;
		
		 
	}
    int isf = 0;

    // Update is called once per frame
    void Update () {
		float t = stopwatch.ElapsedMilliseconds;
			if(t>14999){
				GetComponent<Animator>().enabled = false;
				isf = isf ^ 1;
			}
        if (Input.GetKeyDown("c"))
        {
			
            //DirectorPlayer.Play();
            if (isf == 0)
                GetComponent<Animator>().enabled = false;
            else
            {
               stopwatch = Stopwatch.StartNew();
                GetComponent<Animator>().enabled = true;
               
            }
            isf = isf ^ 1;
        }
    }
}