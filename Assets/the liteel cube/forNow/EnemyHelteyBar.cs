using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHelteyBar : MonoBehaviour
{
    //public static EnemyHelteyBar EEnemyHeltey;
    public Slider slider;
    public Color low;
    public Color hige;
    public Vector3 offset;
    public Vector3 BossPosBar;

    // Start is called before the first frame update
     void Awake()
    {
       // EEnemyHeltey = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetEnemyHelteyBar(float heltey, float maxHeltey)
    {
        slider.gameObject.SetActive(heltey < maxHeltey);
        slider.maxValue = maxHeltey;
        slider.value = heltey;
        //print(slider.fillRect.GetComponentInChildren<Image>().color);
        //slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, hige, slider.normalizedValue);
    }
    private void FixedUpdate()
    {
        if (transform.parent.tag == "enemy")
            fallowEnemy();
    }
    void fallowEnemy()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }
   

}
