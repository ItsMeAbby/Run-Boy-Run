using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	int pos;
	public bool check=false;
	int var=0;

	void Update () {
		
		if(check==false)
		{
			pos = (int)(player.position.z*-1) + var;
			scoreText.text =pos.ToString ("0");

		}
		else
		{
			var += 1000;
			check = false;

		}
			
	}

}