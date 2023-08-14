using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameObject[] mobs;
    [SerializeField]private Vector3 spawnPoint;

    public void TakeDamage()
    {
        _health -= MainClick.powerClicks;
        if(_health <= 0)
        {
            Destroy(mobs[0]);
            _health = 100;
            Instantiate(mobs[0], spawnPoint, Quaternion.identity);

        }
    }
}
