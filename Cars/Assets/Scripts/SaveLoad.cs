using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class SaveLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetString("PartsSelected").Contains(this.gameObject.name + ";"))
        {
            if(this.gameObject.GetComponent<Button>() != null)
            {
                this.gameObject.GetComponent<Image>().color = Color.yellow;
            }
            else
            {
                this.gameObject.tag = "Selected";
            }
        }
	}
}
