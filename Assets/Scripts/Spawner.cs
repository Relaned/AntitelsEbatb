using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject Entity;
    void Start()
    {
        StartCoroutine(SpawnCoolDown());
    }

    
    void Repeat()
    {
        StartCoroutine(SpawnCoolDown());
    }
    IEnumerator SpawnCoolDown()
    {
        yield return new WaitForSeconds(6);
        Instantiate(Entity, SpawnPosition.position, Quaternion.identity);
        Repeat();
    }
}
