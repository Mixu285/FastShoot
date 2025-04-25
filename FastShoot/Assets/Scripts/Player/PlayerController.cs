using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform gunPosition;
    [SerializeField] private GunType gunType;

    private GameObject gun;

    void Start()
    {
        if(gunType == null)
        {
            Debug.LogError("GunType is not assigned in the inspector.");
            return;
        }
        gun = Instantiate(gunType.gunPrefab, gunPosition.position, gunPosition.rotation, gunPosition);
    }
}
