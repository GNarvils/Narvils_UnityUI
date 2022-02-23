using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public Sprite[] Teli;
	float vertiba1, vertiba2;
	public GameObject mainigaisAttels;
	public GameObject slaideris1, slaideris2;
	public GameObject Cepures1, Cepures2, Cepures3, Cepures4;
	public GameObject Sparni1, Sparni2, Sparni3, Sparni4;
	public GameObject Krekli1, Krekli2, Krekli3, Krekli4;
	public GameObject Bikses1, Bikses2, Bikses3, Bikses4;
	public GameObject Aksesuari1, Aksesuari2, Aksesuari3, Aksesuari4;
	public void izvele(int skaitlis){
		if (skaitlis == 0) {
			mainigaisAttels.GetComponent<Image> ().sprite = Teli [0];
		} else if (skaitlis == 1) {
			mainigaisAttels.GetComponent<Image> ().sprite = Teli [1];
		}
			
	}
	public void atteloCepuri(bool vertiba){
		Cepures1.SetActive(vertiba);
		Cepures2.SetActive(vertiba);
		Cepures3.SetActive(vertiba);
		Cepures4.SetActive(vertiba);
	}
	public void atteloSparni(bool vertiba){
		Sparni1.SetActive(vertiba);
		Sparni2.SetActive(vertiba);
		Sparni3.SetActive(vertiba);
		Sparni4.SetActive(vertiba);
	}
	public void atteloKrekli(bool vertiba){
		Krekli1.SetActive(vertiba);
		Krekli2.SetActive(vertiba);
		Krekli3.SetActive(vertiba);
		Krekli4.SetActive(vertiba);
	}
	public void atteloBikses(bool vertiba){
		Bikses1.SetActive(vertiba);
		Bikses2.SetActive(vertiba);
		Bikses3.SetActive(vertiba);
		Bikses4.SetActive(vertiba);
	}
	public void atteloAksesuari(bool vertiba){
		Aksesuari1.SetActive(vertiba);
		Aksesuari2.SetActive(vertiba);
		Aksesuari3.SetActive(vertiba);
		Aksesuari4.SetActive(vertiba);
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
