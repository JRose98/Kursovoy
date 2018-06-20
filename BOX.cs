using UnityEngine;
using System.Collections;

public class BOX : MonoBehaviour {

    public GameObject Dialog;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider cool)
    {
        if (cool.tag == "Player") { Dialog.SetActive(!Dialog.activeSelf); }
    }
}

