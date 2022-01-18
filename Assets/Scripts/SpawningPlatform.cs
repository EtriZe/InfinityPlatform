using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPlatform : MonoBehaviour
{
    public GameObject Platform ;

   
  
    // Start is called before the first frame update

    // On ajoute les première plateformes
    public int livingPlatform = 0;
    public int maxlivingPlatform;
    private float minY = -200f;
    private float maxY = -400f;
    private float minX = 1200f;
    private float maxX = 1300f;
    private Vector2 spawnPosition = new Vector2();

 

    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {

        if (livingPlatform < maxlivingPlatform)
        {
            CreatePlatform();
            livingPlatform = livingPlatform + 1;
        }


    }

   public void CreatePlatform()
    {
        spawnPosition.y = Random.Range(minY, maxY);
        
        spawnPosition.x =Random.Range(minX, maxX);
       
        Instantiate(Platform, spawnPosition, Quaternion.identity);
    }

    public void DeleteLivingPlatform()
    {
        livingPlatform = livingPlatform - 1;
    }


}
