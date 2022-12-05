using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    
    public TextMeshProUGUI score;
    public static float scoreValue=0;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {        
        score.text = "Score " + ((int)scoreValue).ToString();
    }
}
