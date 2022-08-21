using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gunpos;
    Vector2 Diraction;
    public float offset;

    [SerializeField] GameObject bolets;
    private bool ToMove = false;
    Vector3 MosePos;


    [SerializeField] Transform player;
    private bool CanShoute=false;
    Vector2 SotingTo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mospos = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        float rotz = Mathf.Atan2(mospos.y, MosePos.x) * Mathf.Rad2Deg-90f;
         GetComponent<Rigidbody2D>().rotation = rotz;
        //gunpos.transform.right = -Diraction;
        //  moseCliked();
        //shotee();
        // WereToshotee();
    }
   
    private void moseCliked()
    {
        if(Input.GetMouseButtonDown(0))
        {
            WereToshotee();
            CanShoute = true;
        }
        else
        {
            CanShoute = false;
        }
    }
    private void shotee()
    {
        if(CanShoute)
        {
            Instantiate(bolets, player.position, Quaternion.identity);
        }        
    }
    public Vector3 WereToshotee()
    {
        MosePos=Input.mousePosition;
        print(MosePos);
        MosePos = Camera.main.ScreenToWorldPoint(MosePos);
        print(MosePos);
        return MosePos;
    }

   
}
