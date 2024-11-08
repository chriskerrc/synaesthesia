using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 29.5f),
			Mathf.Clamp(transform.position.y, -9f, 10f), transform.position.z);
	}
}
