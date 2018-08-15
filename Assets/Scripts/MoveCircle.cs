using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour {
    public float speed = 2f;
    float timeCounter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //timeCounter = Time.deltaTime;
        //float x = Mathf.Cos(timeCounter);
        //float y = Mathf.Cos(timeCounter);
        //float z = 0;
        //transform.position = new Vector3(x, y, z);
        //transform.Translate(Time.deltaTime * speed, 0, 0);
        transform.Rotate(new Vector3(0, 0, 1));
        transform.Translate(Time.deltaTime*speed, 0, 0);
    }
}
