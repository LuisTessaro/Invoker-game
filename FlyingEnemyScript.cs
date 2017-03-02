using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyScript : MonoBehaviour {
    public GameObject Cold;
    public GameObject Emp;
    public GameObject Sun;
    public GameObject Ghost;
    public GameObject Ice;
    public GameObject Tornado;
    public GameObject Alacrity;
    public GameObject Forge;
    public GameObject Chaos;
    public GameObject Blast;

    public Transform ShootPosition;
    public float max;
    public float min;
    private float a;
    private float t;

    void Start () {
        t = 0f;
        a = generateRandom(min, max);
    }
	

	void Update () {

        t += Time.deltaTime;
        if (t > a)
        {
            Fire(corresponds(generateRandomInt(10, 20)));
            t = 0f;
        }
    }

    private float generateRandom(float min, float max)
    {
        return Random.Range(min, max);
    }

    private int generateRandomInt(int min, int max)
    {
        return Random.Range(min, max);
    }

    public string corresponds(int witch)
    {
        if (witch == 10)
            return "Cold";
        if (witch == 11)
            return "Ghost";
        if (witch == 12)
            return "Ice";
        if (witch == 13)
            return "Emp";
        if (witch == 14)
            return "Tornado";
        if (witch == 15)
            return "Alacrity";
        if (witch == 16)
            return "Sun";
        if (witch == 17)
            return "Forge";
        if (witch == 18)
            return "Chaos";
        if (witch == 19)
            return "Blast";
        return "";
    }

    private void Fire(string s)
    {
        if (s.Equals("Cold"))
        {
            Instantiate(Cold, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Emp"))
        {
            Instantiate(Emp, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Sun"))
        {
            Instantiate(Sun, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Tornado"))
        {
            Instantiate(Tornado, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Ghost"))
        {
            Instantiate(Ghost, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Ice"))
        {
            Instantiate(Ice, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Alacrity"))
        {
            Instantiate(Alacrity, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Forge"))
        {
            Instantiate(Forge, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Chaos"))
        {
            Instantiate(Chaos, ShootPosition.position, Quaternion.identity);
        }
        if (s.Equals("Blast"))
        {
            Instantiate(Blast, ShootPosition.position, Quaternion.identity);
        }

    }
}
