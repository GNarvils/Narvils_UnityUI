using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public Sprite[] Teli;
	float vertiba1, vertiba2;
	public GameObject mainigaisAttels;
	public GameObject slaideris1, slaideris2;
	public void izvele(int skaitlis){
		if (skaitlis == 0) {
			mainigaisAttels.GetComponent<Image> ().sprite = Teli [0];
		} else if (skaitlis == 1) {
			mainigaisAttels.GetComponent<Image> ().sprite = Teli [1];
		}
			
	}
	//public void mainitPlatumu(){
	//	vertiba1 = slaideris1.GetComponent<Slider> ().value;
	//	mainigaisAttels.RectTransform.sizeDelta = new Vector2 (1F * vertiba1, vertiba2);
	//}
	//public void mainitGarumu(){
	//	vertiba2 = slaideris2.GetComponent<Slider> ().value;
	//	mainigaisAttels.RectTransform.sizeDelta = new Vector2 (vertiba1, 1F * vertiba2);
	//}

}
