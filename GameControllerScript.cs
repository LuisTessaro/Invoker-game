using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript1 : MonoBehaviour
{
    public static GameControllerScript1 Instance { get; set; }

    private static int score = 0;
    private static int life;
    private int prfLife;


    public Texture2D lifeTexture;
    public Rect whereLife;
    public AudioClip gettingHit;
    public static Vector3 a;

    void Update()
    {
        if (prfLife != life)
        {
            TriggerSound();
            prfLife = life;
        }
        if(life <= 0)
        {
            PlayerPrefs.SetInt("Highsocore", returnScore());
            SceneManager.LoadScene("DeadSon");
        }
        
    }
    void OnGUI()
    {
        drawVida();
    }

    void drawVida()
    {
        int space = 0;
        for (int i = 0; i < life; i++)
        {
            GUI.DrawTexture(new Rect(whereLife.x + space, whereLife.y, whereLife.width, whereLife.height), lifeTexture);
            space += 61;
        }
    }

    private void Awake()
    {
        PlayerPrefs.SetInt("Highsocore", 0);
        life = 5;
        prfLife = life;
        Instance = this;
    }

    public static int returnScore()
    {
        Debug.Log("Retornou o Score");
        return score;
    }

    public static void addScore()
    {
        Debug.Log("Adicionou o Score");
        score++;
    }

    public static void vidaDecrement()
    {
        Debug.Log("Decrementou a vida");
        life--;
    }

    public void TriggerSound()
    {
        AudioSource.PlayClipAtPoint(gettingHit, a);
    }
    public void sair()
    {
        SceneManager.LoadScene("Menu");
    }
}
