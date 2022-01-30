using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnTime = 25;
    bool canSpawn = false;
    public Transform goblinPrefab;

  public void BeginSpawn()
    {
        canSpawn = true;
    }

    private void Update()
    {
        if (canSpawn)
        {
            Instantiate(goblinPrefab, transform.position, Quaternion.identity);
            StartCoroutine(CooldDown());
        }
    }
    IEnumerator CooldDown()
    {
        canSpawn = false;
        yield return new WaitForSeconds(spawnTime);
        canSpawn = true;
    }
}
