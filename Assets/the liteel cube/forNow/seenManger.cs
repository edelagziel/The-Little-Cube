using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class seenManger : MonoBehaviour
{
    public GameObject UiGameOverPanel;
    public GameObject Player;
    public int EnemyToSowanLevel=1;
    public int EnemyToSponeIndex;
    EnemyKined MyEnemyKiend;
    [SerializeField] private float DropeSpeedHier2=0.2f;
    [SerializeField] private float DropeSpeedLower2=0.1f;

    [SerializeField] Text LevelText;
    [SerializeField] float TimeToadd=15f;
    private int MyCorentlevel = 1;
    [SerializeField] float LevelTime = 30;
    public Text Timetext;
   [SerializeField] private float TimeIs=30;
    public Text ScoreText;
    private GameObject []CopycubeEnemy=new GameObject[1];
    public GameObject cubeEnemy;
    private int spwanPos;
    public float speed;
    Vector2 a;
    public Transform PlayerPos;
   

    private Vector2[] randomspwanPos=new Vector2[4];
    public  Color[] Myenemycolor = new Color[] { Color.blue, Color.red, Color.yellow, Color.cyan, new Color(0.2f, 0.761f, 0.125f, 0f), Color.black, Color.magenta, Color.green, new Color(0.2f, 0.761f, 0.125f, 0f), new Color(255, 255, 255, 255) };

    public int Mycolor;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
       // print(saven);
    }

    // Update is called once per frame
    void Update()
    {
        MyScorey();
        MyTime();
        GameOverPanel();


    }
    void SpawnEnemy()
    {
          CancelInvoke("SpwanEnemy");
         InvokeRepeating("SpwanEnemy", 1.5f, speed);


    }
    void DropEnemy()
    {
        if(speed>2)
        {
            speed -= DropeSpeedHier2;
        }
        
 
        if(speed<=2)
        {
            speed -= DropeSpeedLower2;

        }
    }
    void Mylevel()
    {
        MyCorentlevel++;
        DropEnemy();
        SpawnEnemy();
        LevelText.text = MyCorentlevel.ToString();

    }
    void MyTime()
    {
        TimeIs -= Time.deltaTime;
        Timetext.text = ((int)TimeIs).ToString();
        if(TimeIs<=0)
        {
            TimeIs = LevelTime+(MyCorentlevel* TimeToadd);
            Mylevel();
        }
    }
    void MyScorey()
    {
        ScoreText.text = bulletsBehvior.score.ToString();

    }
     private int SpwanEnemyAcordingLevel()
     {
        MyEnemyKiend = GetComponent<EnemyKined>();

        print(MyCorentlevel + "MyCorentlevel");
        if (EnemyToSowanLevel <= MyEnemyKiend.EnemyProprtis.Length)
        {
            if (MyCorentlevel % 3 == 0)
            {
                if ((MyCorentlevel - EnemyToSowanLevel) % 2 == 0)
                {
                    EnemyToSowanLevel++;

                }
                else
                {
                    print("nop");
                    print(EnemyToSowanLevel + "EnemyToSowanLevel");
                }


            }
        }
        else
        {
            EnemyToSowanLevel = MyEnemyKiend.EnemyProprtis.Length;
        }
        print(EnemyToSowanLevel + "EnemyToSowanLevel");
        return EnemyToSowanLevel;
     }
    void randomEnemy()
    {
        SpwanEnemyAcordingLevel();
        MyEnemyKiend = GetComponent<EnemyKined>();
        //EnemyToSponeIndex = Random.Range(0, MyEnemyKiend.EnemyProprtis.Length);
        EnemyToSponeIndex = Random.Range(0, SpwanEnemyAcordingLevel());

        //EnemyToSponeIndex = Random.Range(0, 0);

          CopycubeEnemy[0].GetComponent<Renderer>().material.color = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].EnemyColor;
          CopycubeEnemy[0].GetComponent<enemy>().TheEnemyNames = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].EnemyName;
          CopycubeEnemy[0].GetComponent<enemy>().EnemyDamge = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyDamge;
          CopycubeEnemy[0].GetComponent<enemy>().addSize = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyImproveSize;
          CopycubeEnemy[0].GetComponent<enemy>().speed = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemySpeed;
          CopycubeEnemy[0].GetComponent<enemy>().MyEnemyMaxLife = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyLife;
          CopycubeEnemy[0].GetComponent<enemy>().MyEnemyLife = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyLife;
          CopycubeEnemy[0].GetComponent<enemy>().NewImroveEnemyLife = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyImproveHeltey;
          CopycubeEnemy[0].GetComponent<enemy>().NewImproveSpeed = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyImproveSpeed;
          CopycubeEnemy[0].GetComponent<enemy>().AddEnemyDamge = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyImproveDamege;
          CopycubeEnemy[0].GetComponent<enemy>().TheEnemyCanShoteBullets = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].CanShote;
          CopycubeEnemy[0].GetComponent<EnemyAi>().Rotationspeedd = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyRotateToTargetSpeed;
          CopycubeEnemy[0].GetComponent<EnemyAi>().rangeToStope = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyDistancToShote;
          CopycubeEnemy[0].GetComponent<EnemyAi>().bulletsSpwanSpeed = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemySumendBulletsSpeed;
          CopycubeEnemy[0].GetComponent<EnemyAi>().BulletsSpeed = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyBulletsSpeed;
          CopycubeEnemy[0].GetComponent<EnemyAi>().BulletsDamge = MyEnemyKiend.EnemyProprtis[EnemyToSponeIndex].TheEnemyBulletsDamge;









    }
    int spwanPosition()
    {
        
         Vector2 a = new Vector2(PlayerPos.position.x + Random.Range(-9, 9),Random.Range(5, 11)+PlayerPos.position.y);
         Vector2 b = new Vector2(PlayerPos.position.x + Random.Range(-9, 9), Random.Range(-5, -11) + PlayerPos.position.y);
         Vector2 c = new Vector2(PlayerPos.position.x+Random.Range(9, 20), Random.Range(-5, 5) + PlayerPos.position.y);
         Vector2 d = new Vector2(PlayerPos.position.x+Random.Range(-9, -20), Random.Range(-5, 5) + PlayerPos.position.y);

        randomspwanPos[0] = a;
        randomspwanPos[1] = b;
        randomspwanPos[2] = c;
        randomspwanPos[3] = d;

        spwanPos = Random.Range(0, randomspwanPos.Length);
        return spwanPos;


    }
    void SpwanEnemy()
    {
        CopycubeEnemy[0]= Instantiate(cubeEnemy, randomspwanPos[spwanPosition()], Quaternion.identity);
        randomEnemy();
       // MyEnemyKiend = gameObject.GetComponent<EnemyKined>();
       // MyEnemyKiend.MyEnemyObgect();
    }
    void GameOverPanel()
    {
        if (Player.GetComponent<PlayerHelte>().helte<=0.1)
        {
            UiGameOverPanel.SetActive(true);
        }
    }
   
}
