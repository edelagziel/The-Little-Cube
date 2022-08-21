using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private bool TimeIsRuning=true;
    [SerializeField] float TimeToServived;
    public Text Level;
    [SerializeField]public int MyLevel;
    public Text TimeIs;
    [SerializeField]float time;
    [HideInInspector]public bool GameOver = false;
    public static Score GameManger;
    [HideInInspector]public int score=0;
   [SerializeField] public int lives=3;
    public Text MyScoreText;
    public GameObject MylivesImage;
    public GameObject GameOverPanel;

    void Awake()
    {
        GameManger = this;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyTimes();
        Levels();
    }
    public void scoris()
    {
        if(!GameOver)
        {
            score++;
            MyScoreText.text = score.ToString();
        }
      


        print("score");
    }
    public void livse()
    {
        StartCoroutine("Mylives");
    }
    public void MyTimes()
    {
        if(TimeIsRuning)
        {
            time -= Time.deltaTime;
            TimeIs.text = ((int)time).ToString();
        }       
    }
    public void Levels()
    {
        Level.text = MyLevel.ToString();
        if (time<=0)
        {
            MyLevel++;
            time = TimeToServived;
            Level.text = MyLevel.ToString();
            SpwanCandis.spwanCandi.SpwanSpeed -= 0.5f;
        }
    }

    IEnumerator Mylives()
    {
        if (lives > 0)
        {
            lives--;
            MylivesImage.transform.GetChild(lives).GetComponent<Image>().color = Color.black;
            yield return new WaitForSeconds(0.7f);
            MylivesImage.transform.GetChild(lives).gameObject.SetActive(false);

        }
        if (lives <= 0)
        {
            //MyScoreText.text = lives.ToString("gameOver");
            SpwanCandis.spwanCandi.CancelInvoke("SpawnCandis");
            GameOver = true;
            GameObject.Find("player").GetComponent<playerMovmentSeries>().canMove = false;
            GameOverPanel.gameObject.SetActive(true);
            TimeIsRuning = false;

        }
    }
}
