using UnityEngine;
using System.Collections;

public class Buy_item : MonoBehaviour
{
	public int		nb_items;
	public bool[]	items_tab;

	void Start ()	// Use this for initialization
	{
		int	cpt;

		items_tab = new bool[nb_items];
		cpt = 0;
		while (cpt != nb_items)
		{
			items_tab[cpt] = false;
			cpt++;
		}
	}

	void Update ()	// Update is called once per frame
	{
	
	}
}
