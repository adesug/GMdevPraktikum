using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour {
	public Transform PlayerTransform;
    private Vector3 _cameraOffset;

	[SerializeField]
	public float SmothFactor = 0.5f;
	
    // Use this for initialization
    void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newPost = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPost, SmothFactor);
		if(Input.GetKey(KeyCode.W)){
            transform.Rotate(new Vector3(-30, 0, 0) * Time.deltaTime);
        }
		if(Input.GetKey(KeyCode.S)){
            transform.Rotate(new Vector3(30, 0, 0) * Time.deltaTime);
        }
		if(Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime);
        }
		if(Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
    }
}
