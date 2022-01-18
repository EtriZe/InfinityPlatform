using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MovingPlatform : MonoBehaviour
{

    private float moveSpeed = 200f;
    private float maxLeftX = -150f;
    private bool breakValue = false;
    public SpawningPlatform otherScript;
  
   
    private void Start()
    {
        otherScript = GameObject.Find("Grid").GetComponent<SpawningPlatform>();
        
        
    }

    
    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetActiveScene().name == "Game")
        {
            if (this.gameObject.transform.position.x > maxLeftX)
            {
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            }
            else
            {
                if (breakValue == false)
                {
                    otherScript.CreatePlatform();
                    breakValue = true;
                }

            }
        }

    }


}
