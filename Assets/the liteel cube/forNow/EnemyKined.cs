using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKined : MonoBehaviour
{
    public SettingSFallowEnemys[] EnemyProprtis = new SettingSFallowEnemys[3];
    //bomber  -red [4] level 4
    //sniper -brown[1] - level 25
    //masingan new color [9]  level 19 magenta
    //regularMidelSuter    level 7-yelow
    //strong shoter enemy level 13 new color orange
    //regular not soting level 10-cyan
    // esey not soting level 1-blue
    // Havey Heltey not soting level 16 black
    // Havey Damge not soting level 22 green
    //perfect Enemy(not stope and sote and strong) white [1] level 28

  /* public void MyEnemyObgect()
    {
         MyseenManger = gameObject.GetComponent<seenManger>();
        EnemyScript= MyseenManger.cubeEnemy.GetComponent<enemy>();
        MyPlayerHelte = MyPlayer.GetComponent<PlayerHelte>();
        EnemyAiScript= MyseenManger.cubeEnemy.GetComponent<EnemyAi>();
        print("MyEnemyObgect funk enter");
        print("corrent color case"+MyseenManger.Mycolor);

        switch (MyseenManger.Mycolor)
        {
            case 0:
                //bllue
                print("bllue");

                EnemyScript.speed = 0.8f;
                EnemyScript.EnemyDamge = 1f;
               // EnemyScript.MyEnemyLife = 100;
               // EnemyScript.MyEnemyMaxLife = 100;
                EnemyScript.addSize=new Vector3(0.4f, 0.4f, 0);
                EnemyScript.NewImroveEnemyLife = 30f;
                EnemyScript.NewImproveSpeed = 0.3f;
                EnemyScript.AddEnemyDamge = 0.5f;






                break;
            case 1:
                //red
                print("red");

                EnemyScript.speed = 6f;
                EnemyScript.EnemyDamge = 10f;
               // EnemyScript.MyEnemyLife = 50;
               // EnemyScript.MyEnemyMaxLife = 50;
                EnemyScript.addSize = new Vector3(-0.2f, -0.2f, 0);
                EnemyScript.NewImroveEnemyLife = 30f;
                EnemyScript.NewImproveSpeed = 0.5f;
                EnemyScript.AddEnemyDamge = 3f;

                break;
            case 2:
                //yyelow

                print("yyelow");
                EnemyScript.speed = 0.9f;
                EnemyScript.EnemyDamge = 2f;
               /// EnemyScript.MyEnemyLife = 150;
               // EnemyScript.MyEnemyMaxLife = 150;
                EnemyScript.addSize = new Vector3(0.4f, 0.4f, 0);
                EnemyScript.NewImroveEnemyLife = 30f;
                EnemyScript.NewImproveSpeed = 0.6f;
                EnemyScript.AddEnemyDamge = 0.9f;

                //   EnemyAiScript.CopeyEnemyBullets[0].GetComponent<EnemyBullets>().speed = 6f;





                break;
            case 3:
                print("cyan");
                EnemyScript.speed = 2f;
                EnemyScript.EnemyDamge = 4f;
                EnemyScript.addSize = new Vector3(0.4f, 0.8f, 0);
                EnemyScript.NewImroveEnemyLife = 60f;
                EnemyScript.NewImproveSpeed = 0.5f;
                EnemyScript.AddEnemyDamge = 2f;
                break;
            case 4:

            break;
            case 5:

            break;
            case 6:

            break;
            case 7:

            break;

            case 8:
               /* public void SpeedSet(float speedd, float currentSpeed)
                {
                    currentSpeed = speed;
                    if (speed < speedd)
                    {
                        print("t");


                        speed = currentSpeed;
                        print("tt");


                    }
                    else
                    {
                        if (speedd == 2)
                        {
                            speed = currentSpeed;
                            print("tt");

                        }
                        else
                        {
                            print("f");
                            speed = speedd;
                        }
                   }
                    break;
            case 9:

            break;

        }
   */ //}

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
