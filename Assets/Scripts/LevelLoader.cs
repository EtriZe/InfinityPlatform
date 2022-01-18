using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    public GameObject Character;
  
   
    private void Start()
    {
        Character = GameObject.Find("Character");
        

    }
    // Update is called once per frame
    void Update()
    {
        if (Character.transform.position.y < -550)
        {
            LoadNextLevel();
        }
      
        
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        if (DoubleJump.bestScore < DoubleJump.myScore)
        {
            DoubleJump.bestScore = DoubleJump.myScore;
        }

    }
        
}
