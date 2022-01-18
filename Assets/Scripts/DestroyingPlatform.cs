using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroyingPlatform : MonoBehaviour
{
    private int limitXLeft = -100;

    public SpawningPlatform otherScript;
    // Update is called once per frame

    private void Start()
    {
        otherScript = GameObject.Find("Grid").GetComponent<SpawningPlatform>();
    }

    void Update()
    {
       
        if ((int)this.gameObject.transform.position.x == limitXLeft )
        {
            if (this.gameObject.name.Contains("First") == false || this.gameObject.name.Contains("Clone"))
            {
                
                otherScript.DeleteLivingPlatform();
                Destroy(this.gameObject);
                
            }
          
        }
    }
}