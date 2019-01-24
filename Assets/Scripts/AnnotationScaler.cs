using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnotationScaler : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		transform.localScale = new Vector3 (0.003f, 0.5f, 0.003f);
		transform.Translate (0f, 0.5f, 0f);
       
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
