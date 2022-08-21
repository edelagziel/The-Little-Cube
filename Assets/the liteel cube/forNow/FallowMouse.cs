using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    private float x;
    private float y;
    public bool playerMovMent=false;
    Transform CubeTransform;
    Vector3 mousePose;
   // [SerializeField] private float x;
   // [SerializeField] private float y;
    [SerializeField] private float Rotationspeed;
    [SerializeField] private float MoveSpedd;

    public GameObject bullets;
    public Transform bulletsPos;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FalowMe();
        shoteAt();
        WASD();

    }
    void WASD()
    {
        if(playerMovMent)
        {
            x = Input.GetAxis("Horizontal")*Time.deltaTime* MoveSpedd;
            y = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpedd;
            transform.Translate(x, y, 0,Space.World);
        }
    }
    void FalowMe()
    {
        if (!playerMovMent)
        {
            mousePose = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePose.z = 0;
            transform.position = Vector3.MoveTowards(transform.position, mousePose, MoveSpedd * Time.deltaTime);
        }

        Vector2 Diraction= Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        float Angle = Mathf.Atan2(Diraction.y, Diraction.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(Angle, Vector3.forward);
        Quaternion rotasine = Quaternion.AngleAxis(Angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotasine, Rotationspeed * Time.deltaTime);
    }
    void shoteAt()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullets, bulletsPos.position, bulletsPos.rotation);
            //print("musebutton");
        }
    }
}
