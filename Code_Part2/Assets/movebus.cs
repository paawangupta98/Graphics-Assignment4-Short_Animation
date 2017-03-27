using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Director;

public class movebus : MonoBehaviour {

	// Use this for initialization
	void Start () {
    
	}
    int t = 0;
    float tr = 0.0f;
    int isf = 0;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            //DirectorPlayer.Play();
            if(isf==0)
                GetComponent<Animator>().enabled = false;
            else
                GetComponent<Animator>().enabled = true;
            isf = isf ^ 1;
        }
        if(isf==0)
        {
            tr += 0.1f;
            transform.Translate(0f, 0f, 0.35f);
        }
        if(Input.GetKeyDown("x"))
        {
        	transform.Rotate(0f , 30f , 0f);
        }
    }
}
