// tu destroy sau 2s
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webinstan : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, .75f);
    }
}

