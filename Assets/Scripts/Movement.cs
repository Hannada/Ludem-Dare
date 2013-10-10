using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	Vector3 Left = new Vector3(-14f, 0f, 0f);
	
	Vector3 Right = new Vector3(14f, 0f, 0f); 
	
	Vector3 Down = new Vector3 (0f, 0f, -14f);
	
	Vector3 Up = new Vector3 (0f, 0f, 14f);
	
	Vector3 Jump = new Vector3(0f, 14f, 0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Right * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Left * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Down * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Up * Time.deltaTime;
		}

		Ray sensor = new Ray(transform.position, Vector3.down);
		
		RaycastHit rayHit = new RaycastHit();

		
		if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(sensor, out rayHit, 1f))
		{
			
			rigidbody.AddForce(Jump, ForceMode.VelocityChange);
		}
	
	}
}
