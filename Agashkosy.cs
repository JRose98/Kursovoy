using UnityEngine;
using System.Collections;

public class Agashkosy : MonoBehaviour {

    int japyrak = 0;
    public GameObject japyrak1;
    public GameObject japyrak2;
    public GameObject japyrak3;
    public GameObject japyrak4;
    public GameObject japyrak5;
    public GameObject japyrak6;
    public GameObject japyrak7;
    public GameObject japyrak8;
    public GameObject SyzJendynyz;
    public GameObject Agashh;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Japyrak")
        {
            japyrak++;
        }

        if (japyrak==8)
        {
            SyzJendynyz.SetActive(!SyzJendynyz.activeSelf);
            Agashh.SetActive(!Agashh.activeSelf);
        }

    }
    }
