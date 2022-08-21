using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    PlayerHelte playerHeltee;
   public float ShotingDamgeToPlayer = 5;

    // Start is called before the first frame update
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
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("hit1");
        if (other.tag == "player")
        {
            print("hit2");
            playerHeltee = other.GetComponent<PlayerHelte>();
            playerHeltee.helte -= ShotingDamgeToPlayer;
            playerHeltee.helteyBarr.SetPlayerHelteyBar(playerHeltee.helte, playerHeltee.Maxhelte);
            if (playerHeltee.helte<=0)
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }


}
