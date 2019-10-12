using UnityEngine;
using UnityEngine.UI;

public class toggletest : MonoBehaviour {

    // Use this for initialization
    Toggle toggle;
	void Start () {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener((a) => {
            bool b = toggle.isOn;
            Color s = b == true ? new Color(1, 1, 1, 0) : new Color(1, 1, 1, 1);
            GetComponentInChildren<Image>().color = s;
        });
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
