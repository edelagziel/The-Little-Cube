using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelte : MonoBehaviour
{
    // Start is called before the first frame update
    enemy MyEnemy;
    public HelteyBar helteyBarr;
    public  float helte = 100;
    public  float Maxhelte = 100;
  //  public float EnemeDamge = 1;
    
    // HelteyBar HelteyBar;

    void Start()
    {
        helteyBarr.SetPlayerHelteyBar(helte, Maxhelte);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       // MyPlayerHeltey();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "enemy")
        {
            MyEnemy=other.GetComponent<enemy>();
            helteyBarr.SetPlayerHelteyBar(helte, Maxhelte);
            helte -= MyEnemy.EnemyDamge * Time.deltaTime;
            // print(helte);
            
           if (MyEnemy.TheEnemyNames== "bomber")
            {
                helteyBarr.SetPlayerHelteyBar(helte, Maxhelte);
                helte -= MyEnemy.EnemyDamge ;
                helteyBarr.SetPlayerHelteyBar(helte, Maxhelte);
                Destroy(other.gameObject);
            }
            if (helte <= 0)
            {
                Destroy(gameObject);
            }

        }
    }

    public void MyPlayerHeltey()
    {
        helte -= MyEnemy.EnemyDamge * Time.deltaTime;
        print(helte);
       // HelteyBar.SetPlayerHelteyBar(helte, Maxhelte);
        if (helte<=0)
        {
            Destroy(gameObject);
        }
    }
   // public void MyEnemyIs()
   // {
    //    for(int i=0;i<)
    //}


      
}
