using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    public int[] qwe = new int[3];

	void Start () {
        qwe[0] = 0;
        qwe[1] = 0;
        qwe[2] = 0;

    }

	void Update () {

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Printando o que tem no vetor "+ printQwe());
            printQwe();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            keyPress(1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            keyPress(2);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            keyPress(3);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(invoke());
        }

    }

    public string invoke()
    {
        return whatIsCasting();
        
    }

    public void keyPress(int key)
    {
        qwe[2] = qwe[1];
        qwe[1] = qwe[0];
        qwe[0] = key;
    }

    public string printQwe()
    {
        string g = "";
        for (int i = 0; i < 3; i++)
        {
            g += qwe[i] + " ";
        }
        return g;
    }

    public string whatIsCasting()
    {
        int q, w, e;
        q = w = e = 0;
        for (int i = 0; i < 3; i++)
        {
            if (qwe[i] == 1)
            {
                q++;
            }
            if (qwe[i] == 2)
            {
                w++;
            }
            if (qwe[i] == 3)
            {
                e++;
            }
        }


        if (q == 3)
        {
            return "Cold";
        }

        if (w == 3)
        {
            return "Emp";
        }

        if (e == 3)
        {
            return "Sun";
        }

        if (q == 2 && w == 1)
        {
            return "Ghost";
        }

        if (q == 2 && e == 1)
        {
            return "Ice";
        }

        if (w == 2 && q == 1)
        {
            return "Tornado";
        }

        if (w == 2 && e == 1)
        {
            return "Alacrity";
        }

        if (e == 2 && q == 1)
        {
            return "Forge";
        }

        if (e == 2 && w ==1)
        {
            return "Chaos";
        }

        if (q == 1 && w == 1 && e==1)
        {
            return "Blast";
        }


        return "No";
    }
}
