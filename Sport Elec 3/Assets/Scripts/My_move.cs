using UnityEngine;
using System.Collections;

public class My_move : MonoBehaviour
{
	public	int			dist_between_lines;
	public	float		z_top;
	public	float		z_bot;
	private bool		pressed;

	void Start ()	// Use this for initialization
	{
		pressed = false;
		z_top = transform.position.z + dist_between_lines;
		z_bot = transform.position.z - dist_between_lines;
	}
	
	void Update ()	// Update is called once per frame
	{
		Vector3		move;
		float		new_z;
		
		if (pressed == false)
		{
			if (Input.GetKey (KeyCode.DownArrow) && transform.position.z != z_bot)
			{
				pressed = true;
				new_z = transform.position.z - dist_between_lines;
				move = new Vector3 (transform.position.x, transform.position.y, new_z);
				transform.position = move;
			}
			else if (Input.GetKey (KeyCode.UpArrow) && transform.position.z != z_top)
			{
				pressed = true;
				new_z = transform.position.z + dist_between_lines;
				move = new Vector3 (transform.position.x, transform.position.y, new_z);		// Todo : voir s'il n'y a pas moyen de modif transform.position.z directement
				transform.position = move;
			}
		}
		else if (Input.GetKey (KeyCode.DownArrow) == false && Input.GetKey (KeyCode.UpArrow) == false)
		{
			pressed = false;
		}
	}
}
