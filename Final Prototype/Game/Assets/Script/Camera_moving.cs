using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_moving : MonoBehaviour {
	private float timer = 5.0f;
	private float count = 1.4f;
	private int flag = 0;

	

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			transform.Translate(Vector3.right * 5 * count);
			flag += 1;
			if (flag == 3){
				transform.Rotate(new Vector3(0, 180, 0));
				transform.Translate(Vector3.right * 5 * count);
				flag = 0;
			}	
		}
		/*timer -= Time.deltaTime;
		if (timer <= 0.0 && flag != 2) {
			count -= Time.deltaTime;
			transform.Translate(Vector3.right * 5 * Time.deltaTime);
			if (count <= 0.0){
				count = 1.5f;
				timer = 5.0f;
				flag += 1;
			}
		}
		
		else if (timer <= 0.0 && flag == 2){
			transform.Rotate(new Vector3(0, 180, 0));
			flag = 0;
			timer = 5.0f;
		}

		if (Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.forward * 4 * Time.deltaTime);
		}

			
		if (Input.GetKey(KeyCode.S)){
			transform.Translate(Vector3.back * 4 * Time.deltaTime);
		}
		
			
		if (Input.GetKey(KeyCode.A)){
			this.transform.Rotate(Vector3.up * -6);

		}
			
		if (Input.GetKey(KeyCode.D)){
			this.transform.Rotate(Vector3.up * 6);

		}*/
		
	}
}
