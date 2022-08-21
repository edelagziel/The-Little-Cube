using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelteyBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Color low;
    public Color hige;
    public Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        fallowPlayer();
    }
    public void SetPlayerHelteyBar(float heltey,float maxHeltey)
    {
        slider.gameObject.SetActive(heltey < maxHeltey);
        slider.maxValue = maxHeltey;
        slider.value = heltey;
        //print(slider.fillRect.GetComponentInChildren<Image>().color);
        //



    }
    void fallowPlayer()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position+ offset);
    }
}
