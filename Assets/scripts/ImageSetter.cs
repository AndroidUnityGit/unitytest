using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageSetter : MonoBehaviour {

    public Image imgae;
    CanvasRenderer canvasRenderer;
    public void SetColor()
    {
        imgae.color = Color.red;
     
    }

	// Use this for initialization
	void Start () {
        //canvasRenderer = GetComponent<CanvasRenderer>();
        //Debug.Log(canvasRenderer.GetColor());
        //Debug.Log(canvasRenderer.GetAlpha());
        //canvasRenderer.SetColor(Color.black);
        //canvasRenderer.SetAlpha(1);
        //Debug.Log(canvasRenderer.GetColor());
        //Debug.Log(transform.GetComponent<RectTransform>().rect.center);
        //Debug.Log(transform.GetComponent<RectTransform>().rect.position);
        //Debug.Log(transform.GetComponent<RectTransform>().rect.yMin);
        //Debug.Log(transform.GetComponent<RectTransform>().rect.size);
        //Debug.Log(transform.GetComponent<RectTransform>().rect.min);
        //Debug.Log(transform.GetComponent<RectTransform>().rect.max);

        //Bounds s = new Bounds(Vector3.zero, Vector3.one);
        //Debug.Log(s.center);
        //Debug.Log(s.size);
        //Debug.Log(s.min);
        //Debug.Log(s.max);
        //Debug.Log("==========");
        //s.Encapsulate(Vector3.one * 2.1f);
        //Debug.Log(s.center);
        //Debug.Log(s.size);
        //Debug.Log(s.min);
        //Debug.Log(s.max);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
