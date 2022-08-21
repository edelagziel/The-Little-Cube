using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
     Transform Player;
    void Start()
    {
        Player=GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Fallow();
    }
    private void Fallow()
    {
        //transform.position=Vector2.MoveTowards(transform.position, Player.position, Time.deltaTime * 0.1f);
        //print(Vector2.MoveTowards(transform.position, Player.position, Time.deltaTime*0.1f));
        transform.position = Vector2.Lerp(transform.position, Player.position, Time.deltaTime);
    }
}
