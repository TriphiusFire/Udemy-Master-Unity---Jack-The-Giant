﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {

    void OnEnable()
    {
        Invoke("DestroyCollectable", 36f);
    }

    void DestroyCollectable()
    {
        gameObject.SetActive(false);
    }


}