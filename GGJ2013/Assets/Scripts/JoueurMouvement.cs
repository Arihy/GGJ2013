using UnityEngine;
using System.Collections;

public class JoueurMouvement : MonoBehaviour {
	private float vitesse = 10.0f;
	private Transform myTransform;
	private float forcePouce;
	
	private Vector3 direction;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		forcePouce = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController character = GetComponent<CharacterController>();
		if(character.isGrounded)
		{
			direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			direction *= vitesse;
		}
		direction.y -= 5.0f * Time.deltaTime;
		character.Move(direction * Time.deltaTime);
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.gameObject.tag == "Plume")
		{
			Rigidbody body = hit.collider.attachedRigidbody;
			if (body == null || body.isKinematic)
            	return;
			
			if(hit.moveDirection.y < -0.3f)
				return;
			
			Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        	body.velocity = pushDir * forcePouce;
		}
	}
}
