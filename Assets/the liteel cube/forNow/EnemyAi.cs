using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : EnemyKined
{
    // Start is called before the first frame update
    public float BulletsDamge;
    public float Rotationspeedd;
    public float BulletsSpeed;
    private GameObject[] CopeyEnemyBullets = new GameObject[1];


    public Transform BollestPos;
    public float DistanceIs;
    public GameObject target;
    public float rangeToStope;
    public bool EnemyStopeMoving=false;
    public enemy EnemyScript;
    public GameObject EnemyBullet;
    public float bulletsSpwanSpeed;
    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("player");
        EnemyScript = gameObject.GetComponent<enemy>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //TargetStopeEnemyDistance();

    }

    private void FixedUpdate()
    {
    }
    
    
    public void MysppedBulletss()
    {
                CopeyEnemyBullets[0].GetComponent<EnemyBullets>().speed = BulletsSpeed;
                CopeyEnemyBullets[0].GetComponent<EnemyBullets>().ShotingDamgeToPlayer = BulletsDamge;
    }
    

    
    public void TargetStopeEnemyDistance()
    {
        EnemyScript = gameObject.GetComponent<enemy>();
        DistanceIs = Vector2.Distance(transform.position, target.transform.position);
        if (DistanceIs<= rangeToStope)
        {
            EnemyStopeMoving = true;
        }
        else
        {
            EnemyStopeMoving = false;
        }
    }
    public void WereToShote()
    {
        Vector2 Diraction = target.transform.position - transform.position;
        float Angle = Mathf.Atan2(Diraction.y, Diraction.x) * Mathf.Rad2Deg;
        transform.rotation= Quaternion.AngleAxis(Angle, Vector3.forward);

    }
    public void WereToShoteSmote()
    {
        Vector2 Diraction = target.transform.position - transform.position;
        float Angle = Mathf.Atan2(Diraction.y, Diraction.x) * Mathf.Rad2Deg;
        //transform.rotation= Quaternion.AngleAxis(Angle, Vector3.forward);
        Quaternion rotasine = Quaternion.AngleAxis(Angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotasine, Rotationspeedd * Time.deltaTime);

    }
    public void EnemyLookeToTarget()
    {
        transform.LookAt(target.transform.position);
    }
    public void EnemyBullets()
    {
        CopeyEnemyBullets[0]=Instantiate(EnemyBullet, BollestPos.position, BollestPos.rotation);
        MysppedBulletss();
    }
    public IEnumerator EnemyShotingSpeedRate()
    {
        EnemyScript = gameObject.GetComponent<enemy>();
        while (EnemyStopeMoving == false)
        {
            print("1f");
            while (EnemyStopeMoving == false)
            {
                yield return null;
                print("2f");

            }
            while (EnemyStopeMoving == true&&EnemyScript.TheEnemyCanShoteBullets)
            {
                //yield return new WaitForSeconds(bulletsSpwanSpeed * Time.deltaTime);
                EnemyBullets();
                yield return new WaitForSeconds(bulletsSpwanSpeed * Time.deltaTime);
                print("1t");

            }
        }
    }
   





}
