using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textTest : MonoBehaviour {

    // Use this for initialization
    Text text;
    RectTransform rectTransform;
    private float length = 350;
	void Start () {
        text = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
        calcuBest("hhhhhhhhhhhhhhhheh还好骄傲家居服来看大家了");
    }
	
	// Update is called once per frame
	void Update () {

        
    }

    private void setWidth(float best)
    {
       
        rectTransform.sizeDelta = new Vector2(best, rectTransform.sizeDelta.y);
    }

    private void calcuBest(string m_Text,bool isfirst=false) {
      //  bool isfirst = false;
        var settings = text.GetGenerationSettings(Vector2.zero);
        float y=0;
        y=text.cachedTextGeneratorForLayout.GetPreferredWidth(m_Text, settings) / text.pixelsPerUnit;
        if (y > length)
        {
            string s = m_Text.Remove(m_Text.Length - 1);
            calcuBest(s,true);
            return;
        }
        else {
            if (isfirst)
            {
                m_Text += "...";
            }                       
             text.text = m_Text;
             settings = text.GetGenerationSettings(Vector2.zero);        
             y = text.cachedTextGeneratorForLayout.GetPreferredWidth(m_Text, settings) / text.pixelsPerUnit;
        }
        setWidth(y);
    }
}
