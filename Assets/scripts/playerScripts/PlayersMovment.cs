using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayersMovment : MonoBehaviour
{
    [SerializeField] float MinValu;
    [SerializeField]float MaxValu;

    float MayRange;
    [SerializeField] float HigeJump;
    Rigidbody2D rb;
    bool CanJump = true;
    Vector2 MyCorentPosY;
    [SerializeField]int SpeedHorizontal;
    float horizontal;
    float Jumping;
    Vector2 YXmovment;
    // Start is called before the first frame update
    void Start()
    {
        MyOriginalPos();
        MoveBetwine();

    }

    // Update is called once per frame
    void Update()
    {
        MyMovment();
        MoveBetwine();
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
       // GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
    }
    protected void frizeYposRigedbodey()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        transform.rotation = Quaternion.identity;

    }
    protected void unFrizeYposRigedbodey()


    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.None;
        transform.rotation = Quaternion.identity;

    }

    protected void MoveBetwine()
    {
        MayRange = Mathf.Clamp(transform.position.x, MinValu, MaxValu);
        transform.position = new Vector2(MayRange, transform.position.y);
    }

    protected void MyOriginalPos()
    {
        MyCorentPosY = GetComponent<Transform>().position;
    }
    protected void MyMovment()
    {
        rb = GetComponent<Rigidbody2D>();
        horizontal = Input.GetAxis("Horizontal") * SpeedHorizontal * Time.deltaTime;
        Jumping= Input.GetAxis("Jump");

          if (GetComponent<Transform>().position.y > MyCorentPosY.y)
          {
              CanJump = false;
          }
          else
          {
              CanJump = true;
            // rb.simulated = false;
            frizeYposRigedbodey();
        }

        if (CanJump)
        {
            if (Jumping > 0)
            {
                unFrizeYposRigedbodey();
                rb.simulated = true;
                rb.velocity = Vector2.up * HigeJump;
            }
            YXmovment = new Vector2(horizontal, 0);
            transform.Translate(YXmovment);
        }
        else
        {
            YXmovment = new Vector2(horizontal, 0);
            transform.Translate(YXmovment);
        }

       
       
    }
}
