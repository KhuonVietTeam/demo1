using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject[] numbers;
    public GameObject Nghin;
    public GameObject Tram;
    public GameObject Chuc;
    public GameObject DonVi;
    int value = CaBatLuoi.point;
    int value1=0;
    GameObject counter;
    int nghin =0;
    int tram = 0;
    int chuc = 0;
    int donvi =0;
    // Use this for initialization
    void Awake()
    {
        numbers = Resources.LoadAll<GameObject>("Numbers");
    }
    void Start () {
        counter = (GameObject)Instantiate(numbers[tram], Tram.transform.position, Tram.transform.rotation);
        counter = (GameObject)Instantiate(numbers[chuc], Chuc.transform.position, Chuc.transform.rotation);
        counter = (GameObject)Instantiate(numbers[donvi], DonVi.transform.position, DonVi.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        value = CaBatLuoi.point;
        if (value - value1 != 0)
        {
            Debug.Log(value);
            Debug.Log(value1);
            value1 = value;
            nghin = value / 1000;
            tram = (value % 1000) / 100;
            chuc = (value % 100) / 10;
            donvi = (value % 100) % 10;
            //counter = (GameObject)Instantiate(numbers[nghin], Nghin.transform.position, Nghin.transform.rotation);
            counter = (GameObject)Instantiate(numbers[tram], Tram.transform.position, Tram.transform.rotation);
            counter = (GameObject)Instantiate(numbers[chuc], Chuc.transform.position, Chuc.transform.rotation);
            counter = (GameObject)Instantiate(numbers[donvi], DonVi.transform.position, DonVi.transform.rotation);
        }
        else
        {

        }
    }
}
