using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScore : MonoBehaviour
{
    private Text myText;
   
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("SaveScore").GetComponent<Text>();

    }

   
    // Update is called once per frame
    void Update()
    {
        myText.text = DoubleJump.bestScore.ToString();
    }
}
