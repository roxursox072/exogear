using UnityEngine;
using UnityEngine.Networking;

public class MechMove : NetworkBehaviour {

private float moveSpeed = 5;
Vector3 currentMovement;
CharacterController controller;

	void Start () 
	{
		controller = GetComponent<CharacterController>();
	}
	
	void Update () 
	{
		move();
	}

	void move()

	{
		if (!isLocalPlayer)
		{
			return;
		}

		if (isLocalPlayer) 
		{
		controller.Move(currentMovement * Time.deltaTime);

		currentMovement = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0, Input.GetAxis("Vertical") *moveSpeed);
		}
	}
}
