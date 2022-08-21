using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MyBlue : enemy
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myEnemy();
    }
}
public class MyRed : ShotingEnemy
{
    // Start is called before the first frame update
    public int dsd;
    void Start()
    {
        MyRed lagziel = new MyYellow();
        lagziel.eden();

    }
    public virtual void eden()
    {

    }
    // Update is called once per frame
    void Update()
    {
        myEnemy();
    }
}
public class MyYellow : MyRed
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myEnemy();
    }
   public override void eden()
    {
        print("lag");
    }
}



