using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamra : MonoBehaviour
{
    public GameObject player;
    private Vector3 Zpos;
    private Vector3 velocity = Vector3.zero;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Zpos = new Vector3(0, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position+ Zpos, ref velocity, speed);
    }
}
