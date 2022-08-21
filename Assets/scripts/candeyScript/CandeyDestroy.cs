using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandeyDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score=0;
    public static int lives = 3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.identity;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (collision.GetComponent<CircleCollider2D>())
            {
                Destroy(this.gameObject);
                Score.GameManger.scoris();
            }    
        }
        if (collision.gameObject.tag == "Groned")
        {           
           Destroy(this.gameObject,1f);
            Score.GameManger.livse();
        }
    }
}
