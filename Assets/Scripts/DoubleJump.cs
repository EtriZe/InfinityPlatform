using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
public class DoubleJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private int numberOfJumpLeft = 2;
    private Text myText;
    public static int myScore = 0;
    public static int bestScore = 0;
   
    public float jumpForce;
    
    
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        myText = GameObject.Find("Nbr").GetComponent<Text>();

        myScore = 0;
    }

  

    void OnCollisionExit2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.transform.position.y < this.gameObject.transform.position.y)
        {
            if (theCollision.gameObject.name.Contains("Platform") == true)
            {
                isGrounded = false;
            }
        }
    }
    
    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.transform.position.y < this.gameObject.transform.position.y)
        {
            myScore = myScore + 1;
            myText.text = myScore.ToString();
          
            if (theCollision.gameObject.name.Contains("Platform") == true)
            {

                isGrounded = true;
                numberOfJumpLeft = 2;
            }
        }
    }
   

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                Jump();
            }
            else if (numberOfJumpLeft > 0)
            {
                Jump();
            }
            else
            {
                
            }
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
        numberOfJumpLeft = numberOfJumpLeft - 1;
    }

}