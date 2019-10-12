using UnityEngine;
using System.Collections;

public class testFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 500);
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
