using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaBatLuoi : MonoBehaviour {
    public static int point;
    public Animator anim;
    public GameObject allCoin;
    GameObject newCoin;
    void Start()
    {
        anim = GetComponent<Animator>();  
    }
    void Awake()
    {
        //allCoin = Resources.Load<GameObject>("Coin");    
    }
    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("Fish1Die", 3, 2f);
            Debug.Log("fish 1 die");
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        //print("trigger");
        if (target.gameObject.CompareTag("web"))
        {
            Debug.Log("Trung");
            //ani.SetBool("chet", true);
            int r = Random.Range(0, 50);
            if (r < 12)
            {
                //txtpoint.addcscore(5);
                //newCoin = (GameObject)Instantiate(allCoin, transform.position, transform.rotation);
                newCoin = Instantiate(allCoin, transform.position, transform.rotation) as GameObject;
                
                Destroy(this.gameObject);  //xoa ca'
                Fishes.allFishCounter--;
                FishGroup.counter--;
                SpecialMap.counter--;
                point++;
                Debug.Log("Chet");
            }
        }

    }
}
