using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishes: MonoBehaviour
{
    public GameObject[] srcfish;
    public Transform noiChua;
    public int soLuong;
    private int chon = 11, sodem;
    private float WBoard = 1300/2 ;
    private float HBoard = 2200/2 ;
    public static int allFishCounter;
    GameObject allfish;
    void Awake()
    {
        srcfish = Resources.LoadAll<GameObject>("Prefabs");
            
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (allFishCounter < soLuong)
        {
            Vector2 pos = new Vector2(0, 0);
            float rt = 0;
            float vl = Random.Range(0, 100);
            if (vl < 70)
            {
                chon = Random.Range(0, 5);
            }
            else if (70 <= vl && vl < 98)
            {
                chon = Random.Range(5, 8);
            }
            else chon = Random.Range(8, 11);
            switch (Random.Range(1, 5))
            {
                case 1://Tren
                    pos = new Vector2(Random.Range(-HBoard, HBoard), WBoard);
                    rt = Random.Range(-120, -60);
                    break;
                case 2://Duoi
                    pos = new Vector2(Random.Range(-HBoard, HBoard), -WBoard);
                    rt = Random.Range(60, 120);
                    break;
                case 3://Phai
                    pos = new Vector2(HBoard, Random.Range(-WBoard, WBoard));
                    rt = Random.Range(120, 240);
                    break;
                case 4://Trai
                    pos = new Vector2(-HBoard, Random.Range(-WBoard, WBoard));
                    rt = Random.Range(-60, 60);
                    break;
            }

            allfish = (GameObject)Instantiate(srcfish[chon], pos, Quaternion.Euler(new Vector3(0, 0, rt)));
            allFishCounter++;
            allfish.name = "cacung"+ chon;
            if(chon == 8 || chon == 9 || chon == 10)
            {
                sodem++;
                if(sodem > 6)
                {
                   // Destroy(srcfish[chon].gameObject);
                }
            }
            Debug.Log(allFishCounter);
            allfish.transform.SetParent(noiChua, false);
        }

    }
}
