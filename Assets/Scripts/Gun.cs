using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject GunGun;
    public GameObject Bullet;
    public GameObject[] AllGun;
    private Vector3 pos;
    GameObject gun;
	// Use this for initialization
    void Awake()
    {
        AllGun = Resources.LoadAll<GameObject>("Prefabs/Gun");
    }
	void Start () {
        pos = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        bool getkey = Input.GetKey(KeyCode.Space);
        if(getkey == true)
        {
            //Instantiate(Bullet, pos, Quaternion.EulerRotation(new Vector3(0, 0, 0)));
        }
      
	}
}
