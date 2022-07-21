using System.Collections;
using System.Collections.Generic;
//using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    int scoreNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreNum += 5;
            //this.GetComponent<Text>().text = "점수 :" + scoreNum.ToString();
            this.GetComponent<Text>().text = $"점수 : {scoreNum}";
        }
    }
}
