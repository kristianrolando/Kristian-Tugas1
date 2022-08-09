using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] ObjectPrefabs;
    [SerializeField] Transform[] spawnPoint;

    public Text waveText;
    public float timeSpawn = 1f;
    public int totalObject;

    int index;
    int currentWave = 1;

    private void Start()
    {
        StartCoroutine(Spawn());
        waveText.text = "Wave : " + currentWave;
    }


    IEnumerator Spawn()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (index == 0)
            {
                while (index < totalObject)
                {
                    index++;
                    int ranPoint = Random.Range(0, spawnPoint.Length);
                    int ranPref = Random.Range(0, ObjectPrefabs.Length);
                    Instantiate(ObjectPrefabs[ranPref], spawnPoint[ranPoint].position, Quaternion.identity);

                    yield return new WaitForSeconds(timeSpawn);
                }
                currentWave += 1;
                yield return new WaitForSeconds(5f);
            }
            else
            {
                waveText.text = "Wave : " + currentWave;
                index = 0;
                totalObject += 5;
            }
        }
    }

}
