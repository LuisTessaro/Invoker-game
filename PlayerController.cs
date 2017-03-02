using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    

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

    public GameObject Colds;
    public GameObject Emps;
    public GameObject Suns;
    public GameObject Ghosts;
    public GameObject Ices;
    public GameObject Tornados;
    public GameObject Alacritys;
    public GameObject Forges;
    public GameObject Chaoss;
    public GameObject Blasts;

    public Texture2D Coldt;
    public Texture2D Empt;
    public Texture2D Sunt;
    public Texture2D Ghostt;
    public Texture2D Icet;
    public Texture2D Tornadot;
    public Texture2D Alacrityt;
    public Texture2D Forget;
    public Texture2D Chaost;
    public Texture2D Blastt;
    public Texture2D Quas;
    public Texture2D Wex;
    public Texture2D Exort;
    public Texture2D InvokeTexture;

    public Texture2D Sword;
    public Texture2D Shield;


    public Rect spell1, spell2, passive1, passive2, passive3, quas,wex,exort,invokeRect,theOne;


    private int[] qwe = new int[3];
    private String[] df = new String[2];

    public Transform castPoint;
    public Transform shieldPoint;

    private bool shieldUp;

    public float shieldCoolDown;
    private float t;

    void Start () {
        qwe[0] = 0;
        qwe[1] = 0;
        qwe[2] = 0;

        df[0] = "";
        df[1] = "";
        t = 0;
        shieldUp = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        if (shieldCoolDown < t)
        {
            shieldUp = false;
            t = 0;
        }
        PlayerInputs();
        RayCasting();

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(qwe[0]);
            Debug.Log(qwe[1]);
            Debug.Log(qwe[2]);

            Debug.Log(df[0]);
            Debug.Log(df[1]);

            Debug.Log(GameControllerScript1.returnScore());
        }

    }
    
    void OnGUI()
    {
        drawPassives();
        drawControls();
        drawCast();
        
    }

    public void shieldSelf(String s)
    {
        if (s.Equals("Cold") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Colds, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Emp") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Emps, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Sun") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Suns, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Tornado") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Tornados, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Ghost") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Ghosts, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Ice") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Ices, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Alacrity") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Alacritys, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Forge") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Forges, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Chaos") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Chaoss, shieldPoint.position, Quaternion.identity);
        }
        if (s.Equals("Blast") && !shieldUp)
        {
            shieldUp = true;
            Instantiate(Blasts, shieldPoint.position, Quaternion.identity);
        }
    }

    public Transform sightStart;
    void RayCasting()
    {
        RaycastHit2D hit = Physics2D.Raycast(sightStart.position, -Vector2.down);
        if (hit.collider != null)
        {
            GameControllerScript1.vidaDecrement();
            Destroy(hit.collider.gameObject);
        }
    }

    public void drawCast()
    {
        if (df[0] == "Cold")
        {
            GUI.DrawTexture(theOne, Coldt);
        }
        if (df[0] == "Ghost")
        {
            GUI.DrawTexture(theOne, Ghostt);
        }
        if (df[0] == "Ice")
        {
            GUI.DrawTexture(theOne, Icet);
        }
        if (df[0] == "Emp")
        {
            GUI.DrawTexture(theOne, Empt);
        }
        if (df[0] == "Tornado")
        {
            GUI.DrawTexture(theOne, Tornadot);
        }
        if (df[0] == "Alacrity")
        {
            GUI.DrawTexture(theOne, Alacrityt);
        }
        if (df[0] == "Sun")
        {
            GUI.DrawTexture(theOne, Sunt);
        }
        if (df[0] == "Forge")
        {
            GUI.DrawTexture(theOne, Forget);
        }
        if (df[0] == "Chaos")
        {
            GUI.DrawTexture(theOne, Chaost);
        }
        if (df[0] == "Blast")
        {
            GUI.DrawTexture(theOne, Blastt);
        }

    }
    public void drawControls()
    {
        if (GUI.Button(spell1,Sword))
        {
            Fire(df[0]);
        }
        if (GUI.Button(spell2, Shield))
        {
            shieldSelf(df[0]);
        }

        if (GUI.Button(quas, Quas))
        {
            keyPress(1);
        }
        if (GUI.Button(wex, Wex))
        {
            keyPress(2);
        }
        if (GUI.Button(exort, Exort))
        {
            keyPress(3);
        }
        if (GUI.Button(invokeRect, InvokeTexture))
        {
            invoke();
        }
    }
    public void drawPassives()
    {
        if (qwe[0] == 1)
        {
            GUI.DrawTexture(passive1, Quas);
        }
        if (qwe[0] == 2)
        {
            GUI.DrawTexture(passive1, Wex);
        }
        if (qwe[0] == 3)
        {
            GUI.DrawTexture(passive1, Exort);
        }

        if (qwe[1] == 1)
        {
            GUI.DrawTexture(passive2, Quas);
        }
        if (qwe[1] == 2)
        {
            GUI.DrawTexture(passive2, Wex);
        }
        if (qwe[1] == 3)
        {
            GUI.DrawTexture(passive2, Exort);
        }

        if (qwe[2] == 1)
        {
            GUI.DrawTexture(passive3, Quas);
        }
        if (qwe[2] == 2)
        {
            GUI.DrawTexture(passive3, Wex);
        }
        if (qwe[2] == 3)
        {
            GUI.DrawTexture(passive3, Exort);
        }

    }
    public void invoke()
    {
        invokePress(whatIsCasting());
    }
    public void invokePress(String name)
    {
        df[1] = df[0];
        df[0] = name;
    }
    public void keyPress(int key)
    {
        qwe[2] = qwe[1];
        qwe[1] = qwe[0];
        qwe[0] = key;
    }
    private void Fire(String s)
    {
        if (s.Equals("Cold"))
        {
            Instantiate(Cold, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Emp"))
        {
            Instantiate(Emp, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Sun"))
        {
            Instantiate(Sun, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Tornado"))
        {
            Instantiate(Tornado, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Ghost"))
        {
            Instantiate(Ghost, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Ice"))
        {
            Instantiate(Ice, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Alacrity"))
        {
            Instantiate(Alacrity, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Forge"))
        {
            Instantiate(Forge, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Chaos"))
        {
            Instantiate(Chaos, castPoint.position, Quaternion.identity);
        }
        if (s.Equals("Blast"))
        {
            Instantiate(Blast, castPoint.position, Quaternion.identity);
        }

    }
    private void PlayerInputs()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Fire(df[0]);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            shieldSelf(df[0]);
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
            invoke();
        }
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

        if (e == 2 && w == 1)
        {
            return "Chaos";
        }

        if (q == 1 && w == 1 && e == 1)
        {
            return "Blast";
        }


        return "No";
    }
}
