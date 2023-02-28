using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float speed = 5f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// movement data
        float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		
		Vector3 move = new Vector3(horizontal, 0, vertical);
		
		transform.position += move * speed * Time.deltaTime;

		// get camera
		Camera camera = Camera.main;
		
		// camera movement
		Vector3 forward = camera.transform.forward;
		Vector3 right = camera.transform.right;
		
		// controlling camera movement
		forward.y = 0f;
		right.y = 0f;
		forward.Normalize();
		right.Normalize();
		
		Vector3 desireDirection = (forward * vertical) + (right * horizontal);
    }
}
