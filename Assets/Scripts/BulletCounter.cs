using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BulletCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI bulletCounter;
    public static int Bullets;
    public static int temp=0;
    void Start()
    {
        Bullets = 10;
        temp=0;
        //GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bulletCounter.text="Bullets - " + (Bullets).ToString();
        if(Bullets==0)
        SceneManager.LoadScene("GameOver");
    }
}
