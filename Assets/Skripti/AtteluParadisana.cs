using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public Sprite[] Teli;
	public GameObject mainigaisAttels;
	public void izvele(int skaitlis){
		if (skaitlis == 0) {
			mainigaisAttels.GetComponent<Image> ().sprite = Teli [0];
		} else if (skaitlis == 1) {
			mainigaisAttels.GetComponent<Image> ().sprite = Teli [1];
		}
			
	}
}
