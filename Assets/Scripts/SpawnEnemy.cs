using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyes;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(enemyes[Random.Range(0, enemyes.Length)], new Vector3(Random.Range(-1.58f, 1.58f), 6f,0f), Quaternion.identity);
            yield return new WaitForSeconds(4);
        }
    }

}
