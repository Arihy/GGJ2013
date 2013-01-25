using UnityEngine;
using System.Collections;

public class JoueurMouvement : MonoBehaviour {
	private float vitesse = 10.0f;
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		float translateX = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
		float translateY = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;
		
		myTransform.Translate(translateX, 0, translateY);
	}
}
