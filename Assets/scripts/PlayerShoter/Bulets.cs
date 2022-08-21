using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulets : MonoBehaviour
{
    // Start is called before the first frame update
    Shoting Shotingg =new Shoting();
    [SerializeField] private float speed;
    private Vector3 WereToshote;
    Rigidbody2D rb;
    Vector2 force;
    private void Awake()
    {
        WereToshote = Shotingg.WereToshotee();
       // WereToshote.z = 0;
       // WereToshote.Normalize();

 

    }
    void Start()
    {
        // WereToshote=Shotingg.WereToshotee();
        Vector2 force = WereToshote * speed*Time.deltaTime;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(force, ForceMode2D.Impulse);
        print(force+"force");
        print(transform.right + "transform.right");
        print(WereToshote+ "WereToshote");
       
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position += transform.position + WereToshote * speed * Time.deltaTime;
       // transform.Translate(WereToshote);
       //transform.position = Vector3.Lerp(transform.position, WereToshote, Time.deltaTime * speed);
        //rb.AddForce(WereToshote.normalized*speed);
      //  rb.AddForce(force, ForceMode2D.Impulse);
       //print(WereToshote * Time.deltaTime);
    }
    private void FixedUpdate()
    {
       // transform.Translate(new Vector2(speed * Time.fixedDeltaTime, 0));
        //transform.Translate(WereToshote);

    }
}
