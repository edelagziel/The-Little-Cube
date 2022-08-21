using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingEnemy : enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void TheShotersEnemy()
    {
        EnemyAi EnemyAiScript = gameObject.GetComponent<EnemyAi>();
            if (EnemyAiScript.EnemyStopeMoving == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, playre.transform.position, speed * Time.deltaTime);
            }
            else if (EnemyAiScript.EnemyStopeMoving == true)
            {
                EnemyAiScript.StartCoroutine("EnemyShotingSpeedRate");
                EnemyAiScript.WereToShote();
            }
    }
}
