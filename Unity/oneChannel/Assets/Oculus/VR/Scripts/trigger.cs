﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "TargetCube" || (other.gameObject.tag == "ShelfThing" && Options.enableWrongCube))
        {
            Destroy(other.gameObject);
            rendering.cubeFound = true;
        }

    }
}
