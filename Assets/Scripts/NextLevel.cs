using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int Enemies;
    public  void Decrement()
    {

        Enemies=Enemies-1;
        if(Enemies==0)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
