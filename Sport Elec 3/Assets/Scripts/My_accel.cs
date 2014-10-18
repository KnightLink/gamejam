using UnityEngine;
using System.Collections;

public class My_accel : MonoBehaviour
{
	public	float	actual_speed;
	public	float	min_speed;
	public	float	normal_speed;
	public	float	max_speed;

	void Start ()	// Use this for initialization
	{
		
	}

	void Update ()	// Update is called once per frame
	{
		if (Input.GetKey (KeyCode.RightArrow))
		{
			actual_speed = max_speed;
		}
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			actual_speed = min_speed;
		}
		else
		{
			actual_speed = normal_speed;
		}
	}
}
