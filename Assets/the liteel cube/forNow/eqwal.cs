using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eqwal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject[] d;

    void Start()
    {
        print(a.Equals(b));

        if (a==b)
        {
            a.Equals(b);
            print("a=b");
        }
        if(a==c)
        {
            print("a=c");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("ok");
        Destroy(gameObject);
    }
}
