using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    NextLevel enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy=GameObject.FindGameObjectWithTag("N").GetComponent<NextLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
            if(BulletCounter.temp<10)
            {
                ScoreCounter.scoreValue = ScoreCounter.scoreValue  - BulletCounter.temp * 10+100;
            }
            BulletCounter.Bullets+=10;
            BulletCounter.temp=0;
            enemy.Decrement();
        }
    }
}
