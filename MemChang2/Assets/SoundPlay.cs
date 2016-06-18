using UnityEngine;
using System.Collections;

public class SoundPlay : MonoBehaviour {

    public AudioClip audioClip;
    //AudioSource audio;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(audioClip, this.transform.position);
    }
    
}
