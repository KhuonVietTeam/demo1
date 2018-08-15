using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacanon : MonoBehaviour {
    public float speed = 90f;
    public Transform noiChua;
    public Object bullet,nextgun,pregun;
    public Transform tras;
    public int scorespend;
    public AudioSource Audio;
    public AudioClip gun;
    GameObject allbullet;
    float t;
    private Animator aniguns;
    // Use this for initialization
    private void Awake()
    {
        aniguns = GetComponent<Animator>();
    }
    void Start () {
        t = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        // su kien xoay trai vaf xoay phai
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 1);
            
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1);
        }
        // su kien ban
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time - t > 0.2f)
            {
                aniguns.SetBool("Fire", true);
                allbullet = (GameObject)Instantiate(bullet, tras.position, tras.rotation);
                Audio.PlayOneShot(gun);
                // txtpoint.addcscore(-scorespend);
                allbullet.transform.SetParent(noiChua, true);
                t = Time.time;
            }
        }
        else aniguns.SetBool("Fire", false);
        // doi sung sau
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(nextgun,transform.position,transform.rotation);
            Destroy(this.gameObject);
        }
        // doi sung truoc
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(pregun,transform.position,transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
