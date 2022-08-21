using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new enemy", menuName = "enemy")]
public class SettingSFallowEnemys : ScriptableObject
{
     
    public string EnemyName;
    public Color EnemyColor;
    public float TheEnemySpeed;
    public float TheEnemyDamge;
    public float TheEnemyLife;

    public Vector3 TheEnemyImproveSize;
    public float TheEnemyImproveHeltey;
    public float TheEnemyImproveSpeed;
    public float TheEnemyImproveDamege;

    public bool CanShote;
    public float TheEnemyDistancToShote;
    public float TheEnemyBulletsSpeed;
    public float TheEnemySumendBulletsSpeed;
    public float TheEnemyRotateToTargetSpeed;
    public float TheEnemyBulletsDamge;




}
