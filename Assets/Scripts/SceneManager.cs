using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    private WebCamTexture mobileCamera;

	// Use this for initialization
	void Start () {
        mobileCamera = new WebCamTexture();
        print(mobileCamera.width);
        print(mobileCamera.height);
        //GetComponent<Renderer>().material.mainTexture = mobileCamera;
        //mobileCamera.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
