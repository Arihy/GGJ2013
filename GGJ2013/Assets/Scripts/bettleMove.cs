using UnityEngine;
using System.Collections;

public class bettleMove : MonoBehaviour {
	private Animation animation;
	public float animSpeed = 1.5f;

	// Use this for initialization
	void Start () {
		animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Z))
		{
		}
		else
		{
			//animation.CrossFade("marche");
		}
	}
}
