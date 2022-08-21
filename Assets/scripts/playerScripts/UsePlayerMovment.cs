using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePlayerMovment : PlayersMovment
{
    // Start is called before the first frame update
    float movment;
    float trnsform;
    float betwen;

    void Start()
    {
        MyOriginalPos();
    }

    // Update is called once per frame
    void Update()
    {
         MyMovment();
        MoveBetwine();
    }
    
}
