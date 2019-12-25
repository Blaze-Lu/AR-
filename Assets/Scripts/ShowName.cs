using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{

    bool isShowInfo;
    bool isEnable;
    public GUIStyle _GUIStyle;
    public float Offset = 15;
    public string Info = "名字";
    //public Button m_PlayButton;
    //Material m_Material;
    // Use this for initialization
    public void Start()
    {
        isShowInfo = false;
        isEnable = false;

        // m_Material = GetComponent<Renderer>().material;
    }
    void OnMouseEnter()
    {
        isShowInfo = true;
       // m_Material.color = Color.red;
        // print("onmouseenter");
    }
    void OnMouseExit()
    {
        isShowInfo = false;
       // m_Material.color = Color.white;
        // print("onmouseexit");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        isEnable = true;
        Debug.Log("Button Clicked. TestClick.");
    }

    void OnGUI()
    {

        if (isEnable)
        {
            if (isShowInfo)
            {
                print("123");
                GUI.Label(new Rect(Input.mousePosition.x + Offset, Screen.height - Input.mousePosition.y, 100, 100), Info, _GUIStyle);
            }
        }
       
    }
}
