using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaUnVecumaIevade : MonoBehaviour {	
	public string vards;
	public string vecums;
	public GameObject ievadeslauksVards;
	public GameObject ievadeslauksVecums;
	public GameObject Izvada;
	public void tekstaAttelosana(){
		vards = ievadeslauksVards.GetComponent<Text> ().text;
		vecums = ievadeslauksVecums.GetComponent<Text> ().text;
		Izvada.GetComponent<Text>().text = "Sveiks mani sauc "+vards+", un man ir "+vecums+" gadi!";
	}
}
