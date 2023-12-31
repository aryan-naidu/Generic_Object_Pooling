using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpScriptableObject", menuName = "ScriptableObjects/NewPowerUpSO")]
public class PowerUpSO : ScriptableObject
{
    public int Id;
    public PowerUpType PowerUptype;
    public int ExtraDamage;
    public float BulletSpeed;
    public int Timer;
}
