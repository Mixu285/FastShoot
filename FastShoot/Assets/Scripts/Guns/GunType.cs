using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class GunType : ScriptableObject
{
    public string gunName;
    public GameObject bulletPrefab;
    public GameObject gunPrefab;
    public float fireRate = 0.5f;
    public float bulletSpeed = 20f;
    public int damage = 10;
}
