using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStarter : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject.FindObjectOfType<Spawner>().BeginSpawn();
    }
}
