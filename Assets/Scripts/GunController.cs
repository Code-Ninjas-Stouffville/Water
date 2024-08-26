using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
	public Vector3 mouse_pos;
	public Transform target;
	public Vector3 object_pos;
	public float angle;

	public Transform target2;
	public Transform target3;


	void Update()
	{
		mouse_pos = Input.mousePosition;
		mouse_pos.z = 5.23f; //The distance between the camera and object
		object_pos = Camera.main.WorldToScreenPoint(target.position);
		mouse_pos.x = mouse_pos.x - object_pos.x;
		mouse_pos.y = mouse_pos.y - object_pos.y;
		angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

		target.transform.position = target2.transform.position;

		if (target.transform.eulerAngles.z > 90 && target.transform.eulerAngles.z < 260)
		{
			target3.localScale = new Vector3(gameObject.transform.localScale.x, -Mathf.Abs(gameObject.transform.localScale.y), gameObject.transform.localScale.z);
		}
		else
		{
			target3.localScale = new Vector3(gameObject.transform.localScale.x, Mathf.Abs(gameObject.transform.localScale.y), gameObject.transform.localScale.z);
		}
	}
}
