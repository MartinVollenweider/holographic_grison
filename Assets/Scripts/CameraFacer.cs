using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GameObject cam = GameObject.FindWithTag("MainCamera");
		//Debug.Log (cam);
		Transform target = cam.transform;
	
		transform.LookAt(target);
		//transform.LookAt (Camera.main.transform.position);
		transform.Rotate (new Vector3 (0, 180f, 0));
	}
}
