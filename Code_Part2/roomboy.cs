using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomboy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
        // Update is called once per frame
	void Update () {
        Texture text1 = Resources.Load("Male3_Head2_Blink", typeof(Texture2D)) as Texture;
        Texture text2 = Resources.Load("Male3_Head2_Sad", typeof(Texture2D)) as Texture;
        var rend = GetComponent<SkinnedMeshRenderer>();
        if (Input.GetKeyDown("1"))
        {
            rend.materials[1].mainTexture = text1;
        }
        else if (Input.GetKeyDown("2"))
        {
            rend.materials[1].mainTexture = text2;
        }
    }
}
