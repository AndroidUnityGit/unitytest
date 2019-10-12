using UnityEngine;
using System.Collections;

public class stringTest : MonoBehaviour {

    string s = "180//180";
	// Use this for initialization
	void Start () {
        //s=s.Replace("//", "/-/");
        // Debug.Log(s);
        s.Replace("//", "/-/");
        Debug.Log(s);
        string[] ss = s.Split('/');
        foreach (var item in ss)
        {
            Debug.Log(item);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
