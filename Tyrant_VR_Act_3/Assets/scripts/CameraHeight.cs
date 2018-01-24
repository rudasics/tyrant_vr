using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CameraHeight : MonoBehaviour {

	//fields
	public GameObject cameraContainer;
	public float height;

	// Use this for initialization
	void Start () {
		cameraContainer.transform.position = new Vector3 (0, height, 0);	
	}
}
