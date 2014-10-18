using UnityEngine;
using System.Collections;

public class Marchand : MonoBehaviour
{
	public	int	item;

	void Start ()	// Use this for initialization
	{

	}

	void Update ()	// Update is called once per frame
	{
		
	}

	void OnTriggerEnter(Collider otherCollider)
	{
		Buy_item component;

		component = otherCollider.GetComponent<Buy_item>();
		component.items_tab[item] = true;
	}
}
