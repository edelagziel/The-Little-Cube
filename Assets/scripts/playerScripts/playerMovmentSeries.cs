using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovmentSeries : MonoBehaviour
{
   // public static playerMovmentSeries playerMovmentSerie;
    public bool canMove = true;
    float MayRange;
    [SerializeField]float MinValu;
    [SerializeField]float MaxValu;
    [SerializeField]float speed;
    float Horizontal;
    Rigidbody2D rb;
    [SerializeField]float jumpHiget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        canMoves();
    }
    protected void MoveBetwine()
    {
        MayRange = Mathf.Clamp(transform.position.x, MinValu, MaxValu);
        transform.position = new Vector2(MayRange, transform.position.y);
    }
    protected void Movment()
    {
        rb = GetComponent<Rigidbody2D>();
        Horizontal = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        transform.Translate(Horizontal, 0, 0);
        if (Input.GetButton("Jump")||Input.GetKey(KeyCode.W))
        {
            if (Mathf.Abs(rb.velocity.y) < 0.001f)
            {
                rb.velocity = Vector2.up * jumpHiget;
            }
        }

    }
    protected void canMoves()
    {
        if(canMove)
        {
            Movment();
            MoveBetwine();
        }

    }

}
