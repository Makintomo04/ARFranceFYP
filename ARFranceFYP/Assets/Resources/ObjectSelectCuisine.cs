using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectSelectCuisine : MonoBehaviour
{
   // private Text label;
  //  private GameObject labelBG;
    //public Text selected;
    public int selectNo;
    public string RaycastReturn;
    Animator animatorET;
    Animator animatorB;
    Animator animatorPDG;
    Animator animatorLM;
    bool etClicked;
    bool bClicked;
    bool pdgClicked;
    bool lmClicked;
    float delay = 0.2f;
    GameObject[] Crois;
    GameObject[] Steak;
    GameObject[] Cheese;
    //GameObject[] LM;
    // public GameObject Foundobject;

    // Start is called before the first frame update
    void Start()
    {
        Crois = GameObject.FindGameObjectsWithTag("Croissant");
        Steak = GameObject.FindGameObjectsWithTag("Croissant");
        Cheese = GameObject.FindGameObjectsWithTag("Croissant");
        //Crois = GameObject.FindGameObjectsWithTag("Croissant");

        /* Bourges = GameObject.FindGameObjectsWithTag("Bourges");
         PDG = GameObject.FindGameObjectsWithTag("Pont du Gard");
         LM = GameObject.FindGameObjectsWithTag("Le Mont-Saint-Michel");
         etClicked = false;
         bClicked = false;
         pdgClicked = false;
         lmClicked = false;
         animatorET = GameObject.Find("Eiffel Tower").GetComponent<Animator>();
         animatorB = GameObject.Find("Bourges").GetComponent<Animator>();
         animatorPDG = GameObject.Find("Pont du Gard").GetComponent<Animator>();
         animatorLM = GameObject.Find("Le Mont Saint-Michel").GetComponent<Animator>();*/
        //label = GameObject.Find("LabelText").GetComponent<Text>();
        // label.text = "";

        // labelBG = GameObject.Find("LabelBGText");
        // labelBG.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if ((Input.GetTouch(0).phase == TouchPhase.Began) /*|| (Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2)*/)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Croissant"))
            {
                selectNo = 1;
                Debug.Log("croissant");
              //  labelBG.SetActive(true);
               // label.text = hit.transform.tag;
                RaycastReturn = hit.collider.gameObject.name;
                //selected.text = hit.transform.name.ToString();
            }
            else if(Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Steak"))
            {
                selectNo = 2;
                Debug.Log("Steak");
                RaycastReturn = hit.collider.gameObject.name;
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Cheese"))
            {
                selectNo = 3;
                Debug.Log("Cheese");
                RaycastReturn = hit.collider.gameObject.name;
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Wine"))
            {
                selectNo = 4;
                Debug.Log("Wine");
                RaycastReturn = hit.collider.gameObject.name;
            }
            // labelBG.SetActive(true);
            /*  // label.text = hit.transform.tag;
               //selected.text = hit.transform.name.ToString();
               etClicked = true;
               //RaycastReturn = hit.collider.gameObject.name;

               foreach (GameObject go in Bourges)
               {
                   if (go.activeSelf == true)
                   {
                       go.SetActive(false);
                   }
               }
               foreach (GameObject go in PDG)
               {
                   if (go.activeSelf == true)
                   {
                       go.SetActive(false);
                   }
               }
               foreach (GameObject go in LM)
               {
                   if (go.activeSelf == true)
                   {
                       go.SetActive(false);
                   }
                   animatorET.Play("ET Grow");

                   Debug.Log("ET");
               }
           }*/


        }
    }
    }
