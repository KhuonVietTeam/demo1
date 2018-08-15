using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGroup : MonoBehaviour
{

    public GameObject[] srcfish;
    public Transform noiChua;
    public int soLuong;
    private int chon;
    private float WBoard = 1500 / 2;
    private float HBoard = 2200 / 2;
    public static int counter;
    float[] mang1 = new float[] { 0, -70, 70, -70, 70, 0, -70, 70, 0 };
    float[] mang2 = new float[] { 0, 70, 70, -70, -70, 70, 0, 0, -70 };
    GameObject allfish;
    void Awake()
    {
        srcfish = Resources.LoadAll<GameObject>("FishGroup");

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter < soLuong)
        {
            float rt = 0;
            float vl = Random.Range(0, 100);
            if (vl < 50)
            {
                chon = 0;
            }
            else if (50 <= vl && vl < 90)
            {
                chon = 1;
            }
            else chon = 2;
            switch (Random.Range(1, 5))
            {
                case 1://Tren
                    int b = Random.Range(3, 9);
                    float vec = Random.Range(-HBoard, HBoard);
                    rt = Random.Range(-120, -60);
                    for (int a = 0; a <= b; a++)
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(vec + mang1[a], WBoard + mang2[a], 0), Quaternion.Euler(new Vector3(0, 0, rt)));
                        Fishes.allFishCounter++;
                        counter++;
                        allfish.name = "FishGroup" + chon;
                        allfish.transform.SetParent(noiChua, false);
                    }
                    break;
                case 2://Duoi
                    b = Random.Range(3, 9);
                    vec = Random.Range(-HBoard, HBoard);
                    rt = Random.Range(60, 120);
                    for (int a = 0; a < b; a++)
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(vec + mang1[a], -WBoard + mang2[a], 0), Quaternion.Euler(new Vector3(0, 0, rt)));
                        Fishes.allFishCounter++;
                        counter++;
                        allfish.name = "FishGroup" + chon;
                        allfish.transform.SetParent(noiChua, false);
                    }
                    break;
                case 3://Phai
                    b = Random.Range(3, 9);
                    vec = Random.Range(-WBoard, WBoard);
                    rt = Random.Range(120, 240);
                    for (int a = 0; a < b; a++)
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(HBoard + mang1[a], vec + mang2[a], 0), Quaternion.Euler(new Vector3(0, 0, rt)));
                        Fishes.allFishCounter++;
                        counter++;
                        allfish.name = "FishGroup" + chon;
                        allfish.transform.SetParent(noiChua, false);
                    }
                    break;
                case 4://Trai
                    b = Random.Range(3, 9);
                    vec = Random.Range(-HBoard, HBoard);
                    rt = Random.Range(-60, 60);
                    for (int a = 0; a < b; a++)
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(HBoard + mang1[a], vec + mang2[a], 0), Quaternion.Euler(new Vector3(0, 0, rt)));
                        Fishes.allFishCounter++;
                        counter++;
                        allfish.name = "FishGroup" + chon;
                        allfish.transform.SetParent(noiChua, false);
                    }
                    break;
            }
        }
    }

}

