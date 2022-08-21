using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTtoroal : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] float HigeJump;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LetsJump();

    }
    void LetsJump()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(0, HigeJump);
            print("need to jump");
        }
        
    }
}
