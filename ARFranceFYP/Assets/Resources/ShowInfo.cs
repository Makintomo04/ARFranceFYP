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
        
   if(Panel != null)
        {
            Panel.SetActive(true);
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
        Panel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
