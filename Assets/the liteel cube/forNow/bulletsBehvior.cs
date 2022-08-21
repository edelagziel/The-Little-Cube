using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bulletsBehvior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public static int PlayerBulletsDamge=30;
    enemy TheEnemyLife;
   [SerializeField] float speed;
    Rigidbody rb;
    public static int score = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ShotingTheBullets();
    }
    void ShotingTheBullets()
    {
        transform.Translate(new Vector3(1,0,0)*Time.deltaTime*speed);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy"|| other.tag == "BossEnemy")
        {
            TheEnemyLife = other.gameObject.GetComponent<enemy>();
            print(TheEnemyLife);
            TheEnemyLife.EnemyDied();
            print(TheEnemyLife.MyEnemyLife);
            if (TheEnemyLife.MyEnemyLife <= 0)
            {
                Destroy(other.gameObject);
                score++;
            }
            Destroy(gameObject);
        }
    }

   
    void enemyHit()
    {
       
    }

}
