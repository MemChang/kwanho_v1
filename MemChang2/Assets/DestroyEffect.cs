using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {

    public AudioClip audioClip;
    public GameObject explosion;
    
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }

    void OnDestroy()
    {
        GameObject go = (GameObject) Instantiate(explosion, transform.position, transform.rotation);
        Destroy(go, 1.0f);        
        
        AudioSource.PlayClipAtPoint(audioClip, this.transform.position);
    }
    
}
