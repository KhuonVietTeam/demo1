using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapefire : MonoBehaviour
{
    int counter = 0; //tranh viec bullet vao point-to-shot Zone thi bi can ban luc o hang code addforce
    public Object obj;
    public float power = 1000f;
    void OnTriggerEnter2D(Collider2D taget)
    {
        if (taget.gameObject.tag == "FirePoint" && counter == 0)
        {
            counter++;
            GetComponent<Rigidbody2D>().AddForce(transform.up * power);
        }
        // khi vien dan cham vao ca
        // khoi tao 1 web tai vi tri va cham
        if (taget.gameObject.tag == "fish")
        {
            Destroy(this.gameObject);
            Instantiate(obj, transform.position,transform.rotation);

        }
    }
}
