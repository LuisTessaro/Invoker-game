using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {
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

    public Transform sightStart, sightEnd;

    public Rigidbody2D rb;
    public int speedMin;
    public int speedMax;

    private float space;

    private bool hasShields;

    public int posicaoRaca;



    public Transform shieldPoint;

    private int amount;
    public int howManyShields;

    public AudioClip clip;
    private Vector2 speed;

    private string tagOfObj;
    private int layer;

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        speed = new Vector2(Random.Range(speedMin, speedMax),0);
        rb.velocity -= speed;
        layer = generateRandom(10, 20);
        tagOfObj = corresponds(layer);
        gameObject.tag = tagOfObj;
        gameObject.layer = layer;

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -speed * Time.deltaTime;
        RayCasting();
    }
    void RayCasting()
    {
        Debug.DrawLine(sightStart.position,sightEnd.position,Color.red);
        if (Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer(tagOfObj)) && gameObject.tag == tagOfObj)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            GameControllerScript1.addScore();
            Destroy(gameObject);
        }
        if (Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Player"))){
            GameControllerScript1.vidaDecrement();
            Destroy(gameObject);
        }
        
    }


    private int generateRandom(int min, int max)
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

    void OnGUI()
    {
        Vector3 V = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        if (gameObject.tag.Equals("Cold"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Coldt);
        }
        if (gameObject.tag.Equals("Ghost"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Ghostt);
        }
        if (gameObject.tag.Equals("Ice"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Icet);
        }
        if (gameObject.tag.Equals("Emp"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Empt);
        }
        if (gameObject.tag.Equals("Tornado"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Tornadot);
        }
        if (gameObject.tag.Equals("Alacrity"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Alacrityt);
        }
        if (gameObject.tag.Equals("Sun"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Sunt);
        }
        if (gameObject.tag.Equals("Forge"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Forget);
        }
        if (gameObject.tag.Equals("Chaos"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Chaost);
        }
        if (gameObject.tag.Equals("Blast"))
        {
            GUI.DrawTexture(new Rect(V.x - 20, Screen.height - V.y + posicaoRaca, 40, 40), Blastt);
        }
    }
}
