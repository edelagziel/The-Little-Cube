using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanCandis : MonoBehaviour
{
    // Start is called before the first frame update
    public static SpwanCandis spwanCandi;
   [SerializeField] private bool ToSpown=false;
    public float SpwanSpeed;
    [SerializeField] float CandeyRangeMinValu;
    [SerializeField] float CandeyRangeMaxValu;
    float RandomValue;
   [SerializeField] private GameObject []Candiys;
    int RandomCandey;
    void Awake()
    {
        spwanCandi = this;
    }
    void Start()
    {
        AllwysSpawnCandis();
        //StartCoroutine("candeySpawn");

    }

    // Update is called once per frame
    void Update()
    {
        // AllwysSpawnCandis();
       // PlayerLievs();

    }
    private void randoms()
    {
        RandomValue = Random.Range(CandeyRangeMinValu, CandeyRangeMaxValu);
        RandomCandey = Random.Range(0, Candiys.Length); 
    }
    public void SpawnCandis()
    {
        randoms();
        Instantiate(Candiys[RandomCandey], new Vector2(RandomValue, 7f), Quaternion.identity);
    }
    public void AllwysSpawnCandis()
    {
        InvokeRepeating("SpawnCandis", 1f, SpwanSpeed);
    }
    private void PlayerLievs()
    {
        if(CandeyDestroy.lives == 0)
        {
            print("game over");
        }
    }
    IEnumerator candeySpawn()
    {
        yield return new WaitForSeconds(2f);
        while(ToSpown)
        {
            SpawnCandis();
            yield return new WaitForSeconds(SpwanSpeed);

        }

    }
}
