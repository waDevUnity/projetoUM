using UnityEngine;
using System.Collections;

public class goalScript : MonoBehaviour {
    public GUIText Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionExit2D(Collision2D coll)
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //if (coll.gameObject.tag == "Caixa")
        Score.text = coll.collider.name;
    }
}
