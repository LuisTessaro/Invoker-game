using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

    public AudioClip clip;

    private float t;

    public float musicSize;


    void Start () {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        if(t > musicSize)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            t = 0;
        }
		
	}
}
