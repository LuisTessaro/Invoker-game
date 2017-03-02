using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour {
    public GameObject enemy;
    public GameObject enemyf;
    private float t;

    public Transform SpawnPosition;
    public float max;
    public float min;
    private float a;

    void Start () {
        t = 0f;
        a = generateRandom(min, max);

    }
	
	// Update is called once per frame
	void Update () {
        
        t += Time.deltaTime;
        a = generateRandom(min, max);
        if (t > a)
        {
            Spawn();
            t = 0f;
        }

    }

    private float generateRandom(float min, float max)
    {
        return Random.Range(min, max);
    }

    private void Spawn()
    {
        Instantiate(enemy, SpawnPosition.position, Quaternion.identity);
    }
}
