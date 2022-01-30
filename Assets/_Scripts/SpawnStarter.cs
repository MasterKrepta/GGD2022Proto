using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStarter : MonoBehaviour
{
    private void OnEnable()
    {
        Spawner[] SPAWNERS = GameObject.FindObjectsOfType<Spawner>();

        foreach (var s in SPAWNERS)
        {
            s.BeginSpawn();
        }

    }
}
