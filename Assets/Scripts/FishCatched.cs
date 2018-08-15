using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCatched : MonoBehaviour {
    public float power = 1000f;
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "FirePoint") GetComponent<Rigidbody2D>().AddForce(transform.up * power);
        // khi vien dan cham vao ca
        // khoi tao 1 web tai vi tri va cham
        if (target.gameObject.tag == "fish")
        {
            Instantiate(this, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
