using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	float _speed = 2f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// transform.translate(Vector3.forward * _speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.D))
		{
			Debug.Log("Right");
			Vector3 _movement = transform.position;
			_movement.z = _movement.z + _speed * Time.deltaTime;
			transform.position = _movement;
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			Debug.Log("Left");
			Vector3 _movement = transform.position;
			_movement.z = _movement.z - _speed * Time.deltaTime;
			transform.position = _movement;
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			Debug.Log("Forward");
			Vector3 _movement = transform.position;
			_movement.x = _movement.x + _speed * Time.deltaTime;
			transform.position = _movement;
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			Debug.Log("Forward");
			Vector3 _movement = transform.position;
			_movement.x = _movement.x - _speed * Time.deltaTime;
			transform.position = _movement;
		}
    }
}
