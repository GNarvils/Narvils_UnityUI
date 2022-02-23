	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class KursorsUzAttela : MonoBehaviour {
		public AudioSource skanasAvots;
		public AudioClip skanaKoAtskenot;
		public void  uzbiditsUzAttela(){
		Debug.Log ("Skana Spele");
		skanasAvots.PlayOneShot (skanaKoAtskenot);
		}
		public void  nobiditsUzAttela(){
			skanasAvots.Stop ();
		}
	}
