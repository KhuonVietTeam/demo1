using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject[] numbers;
    public GameObject Nghin;
    public GameObject Tram;
    public GameObject Chuc;
    public GameObject DonVi;
    int value;
    GameObject counter;
    // Use this for initialization
    void Awake()
    {
        numbers = Resources.LoadAll<GameObject>("Numbers");
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        value = CaBatLuoi.point;
        int nghin = value / 1000;
        int tram = (value%1000)/100;
        int chuc = (value % 100) / 10;
        int donvi = (value % 100) % 10;
        //counter = (GameObject)Instantiate(numbers[nghin], Nghin.transform.position, Nghin.transform.rotation);
        counter = (GameObject)Instantiate(numbers[tram], Tram.transform.position, Tram.transform.rotation);
        counter = (GameObject)Instantiate(numbers[chuc], Chuc.transform.position, Chuc.transform.rotation);
        counter = (GameObject)Instantiate(numbers[donvi], DonVi.transform.position, DonVi.transform.rotation);
    }
}
