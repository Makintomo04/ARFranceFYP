using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour
{
 //   public GameObject Info;
  //  public GameObject Info2;
  //  public GameObject InfoBG;
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    [SerializeField] Sprite[] infoSprites;
    public ObjectSelect OSRef;
    //public GameObject Label;
    //bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        
        // Info = GameObject.Find("InfoText");
        // Info2 = GameObject.Find("InfoText2");
        // Info.SetActive(false);
        // Info2.SetActive(false);
        // InfoBG = GameObject.Find("InfoBGText");
        // InfoBG.SetActive(false);
        //isClicked = false;
    }

    public void OpenPanel()
    {
       
        if (OSRef.selectNo==1)
        {
            gameObject.GetComponent<Image>().sprite = infoSprites[1];
            if (Panel2.activeSelf == true)
            {
                Panel2.SetActive(false);
            }
            if (Panel3.activeSelf == true)
            {
                Panel3.SetActive(false);
            }
            if (Panel4.activeSelf == true)
            {
                Panel4.SetActive(false);
            }
            if (Panel5.activeSelf == true)
            {
                Panel5.SetActive(false);
            }
            Panel.SetActive(true);

            Debug.Log("ET");
        }
        /*if (Panel2 != null && OSRef.selectNo==2)
        {
            if (Panel.activeSelf == true)
            {
                Panel.SetActive(false);
            }
            if (Panel3.activeSelf == true)
            {
                Panel3.SetActive(false);
            }
            if (Panel4.activeSelf == true)
            {
                Panel4.SetActive(false);
            }
            if (Panel5.activeSelf == true)
            {
                Panel5.SetActive(false);
            }
            Panel2.SetActive(true);
            Debug.Log("ND");
        }*/
     else   if (Panel3 != null && OSRef.selectNo==3)
        {
            gameObject.GetComponent<Image>().sprite = infoSprites[1];
            if (Panel.activeSelf == true)
            {
                Panel.SetActive(false);
            }
            if (Panel2.activeSelf == true)
            {
                Panel2.SetActive(false);
            }
            if (Panel4.activeSelf == true)
            {
                Panel4.SetActive(false);
            }
            if (Panel5.activeSelf == true)
            {
                Panel5.SetActive(false);
            }
            Panel3.SetActive(true);
            Debug.Log("B");
        }
    else if (Panel4 != null && OSRef.selectNo==4)
        {
            gameObject.GetComponent<Image>().sprite = infoSprites[1];
            if (Panel.activeSelf == true)
            {
                Panel.SetActive(false);
            }
            if (Panel2.activeSelf == true)
            {
                Panel2.SetActive(false);
            }
            if (Panel3.activeSelf == true)
            {
                Panel3.SetActive(false);
            }
            if (Panel5.activeSelf == true)
            {
                Panel5.SetActive(false);
            }
            Panel4.SetActive(true);
            Debug.Log("PDG");
        }
      else if (Panel5 != null && OSRef.selectNo==5)
        {
            gameObject.GetComponent<Image>().sprite = infoSprites[1];
            if (Panel.activeSelf == true)
            {
                Panel.SetActive(false);
            }
             if (Panel2.activeSelf == true)
            {
                Panel2.SetActive(false);
            }
             if (Panel3.activeSelf == true)
            {
                Panel3.SetActive(false);
            }
            if (Panel4.activeSelf == true)
            {
                Panel4.SetActive(false);
            }
            Panel5.SetActive(true);
            Debug.Log("LM");
        }
        else if(Panel != null && Panel3 != null && Panel4 != null && Panel5 != null && OSRef.selectNo == 0){
            if (Panel.activeSelf == true)
            {
                Panel.SetActive(false);
            }
            if (Panel2.activeSelf == true)
            {
                Panel2.SetActive(false);
            }
            if (Panel3.activeSelf == true)
            {
                Panel3.SetActive(false);
            }
            if (Panel4.activeSelf == true)
            {
                Panel4.SetActive(false);
            }
            if (Panel5.activeSelf == true)
            {
                Panel5.SetActive(false);
            }
            Debug.Log("Nothing Selected");
        }

        //InfoBG.SetActive(true);
        //Info.SetActive(true);
        //isClicked = true;

        /* else if (Label.GetComponent<UnityEngine.UI.Text>().text == "The Notre Dame")
         {
             InfoBG.SetActive(true);
             Info2.SetActive(true);
             //isClicked = true;
         }*/
        /*if (isClicked)
        {
            Info.SetActive(false);
            Info2.SetActive(false);
            InfoBG.SetActive(false);
            isClicked = false;
        }*/
    }
    public void ExitPanel()
    {
        if (Panel.activeSelf == true)
        {
            Panel.SetActive(false);
        }
        if(Panel2.activeSelf == true)
        {
            Panel2.SetActive(false);
        }
        if (Panel3.activeSelf == true)
        {
            Panel3.SetActive(false);
        }
        if (Panel4.activeSelf == true)
        {
            Panel4.SetActive(false);
        }
        if (Panel5.activeSelf == true)
        {
            Panel5.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Panel.activeSelf == false && Panel2.activeSelf == false && Panel3.activeSelf == false && Panel4.activeSelf == false && Panel5.activeSelf == false)
        {
            gameObject.GetComponent<Image>().sprite = infoSprites[0];
        }
    }
}
