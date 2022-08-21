using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : EnemyKined
{
    public string TheEnemyNames;
    public bool TheEnemyCanShoteBullets;






    //public EnemyHelteyBar enemyHelteyBarr;
    //public EnemyAi EnemyAiScript;
    public int MyEnemyIndexCurrentColor;
    public Color MyEnemyCurrentColor;
    public float EnemyDamge;
    public float AddEnemyDamge ;
    PlayerHelte MyPlayerHelte;
    enemy NewBigEnemy;
    public float NewImproveSpeed;
    public float NewImroveEnemyLife ;
    public float MyEnemyLife;
    public float MyEnemyMaxLife;

    public Vector3 addSize;
    private GameObject CopyObgectEnemySpone;
    public GameObject ObgectEnemySpone;
    private Vector3  enemySize;
    public float speed;
    protected GameObject playre;
    Vector3 enemyNewPos;
    // Start is called before the first frame update
    private void Awake()
    {
        playre = GameObject.FindGameObjectWithTag("player");


    }
    void Start()
    {       
        gameObject.GetComponentInChildren<EnemyHelteyBar>().SetEnemyHelteyBar(MyEnemyLife, MyEnemyMaxLife);
        EnemyAi EnemyAiScript = gameObject.GetComponent<EnemyAi>();
        EnemyAiScript.StartCoroutine("EnemyShotingSpeedRate");
    }

   


    // Update is called once per frame
    void Update()
    {
        myEnemy();
       
    }
    public void EnemyDied()
    {
        MyEnemyLife -= bulletsBehvior.PlayerBulletsDamge;
        gameObject.GetComponentInChildren<EnemyHelteyBar>().SetEnemyHelteyBar(MyEnemyLife, MyEnemyMaxLife);
    }
    public virtual void myEnemy()
    {

           EnemyAi EnemyAiScript = gameObject.GetComponent<EnemyAi>();
           MyEnemyCurrentColor = GetComponent<Renderer>().material.color;
           EnemyAiScript.TargetStopeEnemyDistance();
        if (TheEnemyCanShoteBullets)        
        {
                    print(TheEnemyCanShoteBullets+"true");
                   if (EnemyAiScript.EnemyStopeMoving == false)
                   {
                       transform.position = Vector3.MoveTowards(transform.position, playre.transform.position, speed * Time.deltaTime);
                       EnemyAiScript.WereToShote();
                       print(EnemyAiScript.EnemyStopeMoving + "false");

                   }

           else if (EnemyAiScript.EnemyStopeMoving == true)
           {
                       EnemyAiScript.StartCoroutine("EnemyShotingSpeedRate");
                       EnemyAiScript.WereToShoteSmote();
                       print(EnemyAiScript.EnemyStopeMoving + "true");

           }
        }  
            else
            {
               EnemyAiScript.WereToShote();
               transform.position = Vector3.MoveTowards(transform.position, playre.transform.position, speed * Time.deltaTime);
               print(TheEnemyCanShoteBullets + "false");

            }



    }


    private void OnTriggerEnter(Collider other)
    {      
        if (other.tag == "enemy"||other.tag=="BossEnemy")
        {
            if(GetComponent<Renderer>().material.color==other.GetComponent<Renderer>().material.color)
            {
               // print("sameColor");
                enemyNewPos = other.GetComponent<Transform>().position;
                enemySize = gameObject.GetComponent<Transform>().localScale;
                if(enemySize == other.gameObject.GetComponent<Transform>().localScale)
                {
                    //print("sameSize");
                    if(gameObject.GetComponent<Transform>().position.x>other.GetComponent<Transform>().position.x)
                    {
                        CopyObgectEnemySpone=Instantiate(ObgectEnemySpone, enemyNewPos, Quaternion.identity);
                        CopyObgectEnemySpone.GetComponent<Transform>().localScale = enemySize + addSize;
                        NewBigEnemy = CopyObgectEnemySpone.GetComponent<enemy>();
                        NewBigEnemy.MyEnemyMaxLife += NewImroveEnemyLife;
                        NewBigEnemy.MyEnemyLife= NewBigEnemy.MyEnemyMaxLife;
                        NewBigEnemy.speed += NewImproveSpeed;
                        NewBigEnemy.EnemyDamge += NewBigEnemy.AddEnemyDamge;
                    }
                    Destroy(gameObject);                    
                }

            }
                     
        }

    }
   
    
    public void MyEnemyObgect()
    {
         MyPlayerHelte = playre.GetComponent<PlayerHelte>();
        EnemyAi EnemyAiScript = gameObject.GetComponent<EnemyAi>();
        //print("MyEnemyObgect funk enter");
       // MyEnemyIndexCurrentColors();
        switch (MyEnemyIndexCurrentColor)
        {
            case 0:
                //bllue
                print("bllue");
              //  SpeedSet(speeed, 0.8f);
               // speed = 0.8f;
              //  EnemyDamge = 1f;
               // MyEnemyLife = 60;
               // MyEnemyMaxLife = 60;
               // addSize = new Vector3(0.4f, 0.4f, 0);
             //   NewImroveEnemyLife = 30f;
                //NewImproveSpeed = 0.3f;
               // AddEnemyDamge = 0.5f;






                break;
            case 1:
                //red
                print("red");
               // SpeedSet(speeed, 6f);

            //    speed = 6f;
               // EnemyDamge = 10f;
             //   MyEnemyLife = 60;
             //   MyEnemyMaxLife = 60;
              //  addSize = new Vector3(-0.2f, -0.2f, 0);
              //  NewImroveEnemyLife = 30f;
                //NewImproveSpeed = 0.5f;
              //  AddEnemyDamge = 3f;

                break;
            case 2:
                //yyelow

                print("yyelow");
                //SpeedSet(speeed, 1.5f);

              //  speed = 1.5f;
              //  EnemyDamge = 2f;
               // MyEnemyLife = 150;
               // MyEnemyMaxLife = 150;
              //  addSize = new Vector3(0.3f, 0.4f, 0);
                //NewImroveEnemyLife = 40f;
                //NewImproveSpeed = 0.4f;
              //  AddEnemyDamge = 3f;

                //   EnemyAiScript.CopeyEnemyBullets[0].GetComponent<EnemyBullets>().speed = 6f;





                break;
            case 3:
                print("cyan");
               // speed = 2f;
              //  EnemyDamge = 4f;
              //  addSize = new Vector3(0.4f, 0.8f, 0);
               // NewImroveEnemyLife = 60f;
                //NewImproveSpeed = 0.5f;
               // AddEnemyDamge = 2f;
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

                break;
            case 9:

                break;

        }
    }


}
