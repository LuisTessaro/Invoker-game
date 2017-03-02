using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getScore : MonoBehaviour {
    private int score;
    public Text scoreText;

    private void Start ()
    {
        score = PlayerPrefs.GetInt("Highsocore");
        scoreText.text = "Seu score foi " + score;

    }
	public void ToGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
