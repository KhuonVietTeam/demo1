using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luoibatca : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D taget)
    {
            if (taget.gameObject.tag == "fish")
            {
                Debug.Log("Trung");
                //ani.SetBool("chet", true);
                int r = Random.Range(0, 50);
                if (r < 12)
                {
                    //txtpoint.addcscore(5);
                    Destroy(this.gameObject);
                    Fishes.allFishCounter--;
                    Debug.Log("Chet");
            }
            }
    }
}
