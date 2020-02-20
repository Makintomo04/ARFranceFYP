using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelect : MonoBehaviour
{
    private Text label;
    private GameObject labelBG;
    // public Text selected;
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
    GameObject[] ET;
    GameObject[] Bourges;
    GameObject[] PDG;
    GameObject[] LM;
    // public GameObject Foundobject;

    // Start is called before the first frame update
    void Start()
    {
        ET = GameObject.FindGameObjectsWithTag("Eiffel Tower");
        Bourges = GameObject.FindGameObjectsWithTag("Bourges");
        PDG = GameObject.FindGameObjectsWithTag("Pont du Gard");
        LM = GameObject.FindGameObjectsWithTag("Le Mont-Saint-Michel");
        etClicked = false;
        bClicked = false;
        pdgClicked = false;
        lmClicked = false;
        animatorET = GameObject.Find("Eiffel Tower").GetComponent<Animator>();
        animatorB = GameObject.Find("Bourges").GetComponent<Animator>();
        animatorPDG = GameObject.Find("Pont du Gard").GetComponent<Animator>();
        animatorLM = GameObject.Find("Le Mont Saint-Michel").GetComponent<Animator>();
        label = GameObject.Find("LabelText").GetComponent<Text>();
        label.text = "";

        labelBG = GameObject.Find("LabelBGText");
        labelBG.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        /* if (Input.GetMouseButtonDown(0))
         {
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
             if (Physics.Raycast(ray, out hit))
             {
                 labelBG.SetActive(true);
                 label.text = hit.transform.name.ToString();
                 //  selected.text = hit.transform.name.ToString();
                 if (hit.collider.gameObject.CompareTag("Eiffel Tower"))
                 {
                     if (etClicked == false)
                     {
                         etClicked = true;
                         //RaycastReturn = hit.collider.gameObject.name;
                         selectNo = 1;
                         GameObject.FindGameObjectWithTag("Bourges").SetActive(false);
                         GameObject.FindGameObjectWithTag("PDG").SetActive(false);
                         GameObject.FindGameObjectWithTag("Le Mont").SetActive(false);
                         animatorET.Play("ET Grow");

                     }
                     else if (etClicked == true)
                     {
                         etClicked = false;
                         GameObject.FindGameObjectWithTag("Bourges").SetActive(true);
                         GameObject.FindGameObjectWithTag("PDG").SetActive(true);
                         GameObject.FindGameObjectWithTag("Le Mont").SetActive(true);
                         animatorET.Play("ET Return");

                     }
                     Debug.Log("ET");
                 }
                 else if (hit.collider.gameObject.CompareTag("Notre Dame"))
                 {
                     selectNo = 2;
                     Debug.Log("ND");
                 }
                 else if (hit.collider.gameObject.CompareTag("Bourges"))
                 {
                     selectNo = 3;
                     Debug.Log("B");
                 }
                 else if (hit.collider.gameObject.CompareTag("PDG"))
                 {
                     selectNo = 4;
                     Debug.Log("PDG");
                 }
                 else if (hit.collider.gameObject.CompareTag("Le Mont"))
                 {
                     selectNo = 5;
                     Debug.Log("LM");
                 }

             }
             else
             {
                 selectNo = 0;
                 labelBG.SetActive(false);
                 label.text = "";
             }


     }*/


        if ((Input.GetTouch(0).phase == TouchPhase.Began) /*|| (Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2)*/)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Eiffel Tower") && etClicked == false)
            {
                selectNo = 1;
                labelBG.SetActive(true);
                label.text = hit.transform.tag;
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
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Eiffel Tower") && etClicked == true)
            {
                etClicked = false;
                selectNo = 0;
                labelBG.SetActive(false);
                label.text = "";
                foreach (GameObject go in Bourges)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in PDG)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in LM)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                animatorET.Play("ET Return");

            }
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Bourges") && bClicked == false)
            {
                bClicked = true;
                //RaycastReturn = hit.collider.gameObject.name;
                selectNo = 3;

                foreach (GameObject go in ET)
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
                }

                /*  GameObject.FindGameObjectWithTag("Eiffel Tower").SetActive(false);
                  GameObject.FindGameObjectWithTag("PDG").SetActive(false);
                  GameObject.FindGameObjectWithTag("Le Mont").SetActive(false);*/
                animatorB.Play("B Grow");

                Debug.Log("B");
            }

            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Bourges") && bClicked == true)
            {
                bClicked = false;
                selectNo = 0;
                labelBG.SetActive(false);
                label.text = "";

                foreach (GameObject go in ET)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in PDG)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in LM)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                /*GameObject.FindGameObjectWithTag("Eiffel Tower").SetActive(true);

                GameObject.FindGameObjectWithTag("PDG").SetActive(true);

                GameObject.FindGameObjectWithTag("Le Mont").SetActive(true);*/
                animatorB.Play("B Return");

            }
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Pont du Gard") && pdgClicked == false)
            {
                pdgClicked = true;
                selectNo = 4;
                foreach (GameObject go in ET)
                {
                    if (go.activeSelf == true)
                    {
                        go.SetActive(false);
                    }
                }
                foreach (GameObject go in Bourges)
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
                }
                animatorPDG.Play("PDG Grow");
                Debug.Log("PDG");
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Pont du Gard") && pdgClicked == true)
            {
                pdgClicked = false;
                selectNo = 0;
                labelBG.SetActive(false);
                label.text = "";
                foreach (GameObject go in ET)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in Bourges)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }

                foreach (GameObject go in LM)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                animatorPDG.Play("PDG Return");

            }
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Le Mont-Saint-Michel") && lmClicked == false)
            {
                lmClicked = true;
                selectNo = 5;
                foreach (GameObject go in ET)
                {
                    if (go.activeSelf == true)
                    {
                        go.SetActive(false);
                    }
                }
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
                animatorLM.Play("LM Grow");
                Debug.Log("LM");
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Le Mont-Saint-Michel") && lmClicked == true)
            {
                lmClicked = false;
                selectNo = 0;
                labelBG.SetActive(false);
                label.text = "";
                foreach (GameObject go in ET)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in Bourges)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }

                foreach (GameObject go in PDG)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                animatorLM.Play("LM Return");

            }
        
        
    }
            /* //ET
             if (hit.collider.gameObject.CompareTag("Eiffel Tower") && etClicked == false)
                 {
                     etClicked = true;
                     //RaycastReturn = hit.collider.gameObject.name;
                     selectNo = 1;
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
                     }
                     animatorET.Play("ET Grow");

                     Debug.Log("ET");
                 }

                 else if (hit.collider.gameObject.CompareTag("Eiffel Tower") && etClicked == true)
                 {
                     etClicked = false;
                     selectNo = 0;
                     labelBG.SetActive(false);
                     label.text = "";
                     foreach (GameObject go in Bourges)
                     {
                         if (go.activeSelf == false)
                         {
                             go.SetActive(true);
                         }
                     }
                     foreach (GameObject go in PDG)
                     {
                         if (go.activeSelf == false)
                         {
                             go.SetActive(true);
                         }
                     }
                     foreach (GameObject go in LM)
                     {
                         if (go.activeSelf == false)
                         {
                             go.SetActive(true);
                         }
                     }
                     animatorET.Play("ET Return");

                 }
                 

            /* if (hit.collider.gameObject.CompareTag("Notre Dame"))
             {
                 selectNo = 2;
                 Debug.Log("ND");
             }*/
            //Bourges
            /* if (hit.collider.gameObject.CompareTag("Bourges") && bClicked == false)
                 {
                     bClicked = true;
                     //RaycastReturn = hit.collider.gameObject.name;
                     selectNo = 3;

                     foreach (GameObject go in ET)
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
                     }

                     /*  GameObject.FindGameObjectWithTag("Eiffel Tower").SetActive(false);
                       GameObject.FindGameObjectWithTag("PDG").SetActive(false);
                       GameObject.FindGameObjectWithTag("Le Mont").SetActive(false);*/
            //    animatorB.Play("B Grow");

            //   Debug.Log("B");


        
        /*
            else if (hit.collider.gameObject.CompareTag("Bourges") && bClicked == true)
            {
                bClicked = false;
                selectNo = 0;
                labelBG.SetActive(false);
                label.text = "";

                foreach (GameObject go in ET)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in PDG)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                foreach (GameObject go in LM)
                {
                    if (go.activeSelf == false)
                    {
                        go.SetActive(true);
                    }
                }
                /*GameObject.FindGameObjectWithTag("Eiffel Tower").SetActive(true);

                GameObject.FindGameObjectWithTag("PDG").SetActive(true);

                GameObject.FindGameObjectWithTag("Le Mont").SetActive(true);*/
        //   animatorB.Play("B Return");

        //   }
        //PDG               
        /*   if (hit.collider.gameObject.CompareTag("Pont du Gard") && pdgClicked == false)
           {
               pdgClicked = true;
               selectNo = 4;
               foreach (GameObject go in ET)
               {
                   if (go.activeSelf == true)
                   {
                       go.SetActive(false);
                   }
               }
               foreach (GameObject go in Bourges)
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
               }
               animatorPDG.Play("PDG Grow");
               Debug.Log("PDG");
           }
           else if (hit.collider.gameObject.CompareTag("Pont du Gard") && pdgClicked == true)
           {
               pdgClicked = false;
               selectNo = 0;
               labelBG.SetActive(false);
               label.text = "";
               foreach (GameObject go in ET)
               {
                   if (go.activeSelf == false)
                   {
                       go.SetActive(true);
                   }
               }
               foreach (GameObject go in Bourges)
               {
                   if (go.activeSelf == false)
                   {
                       go.SetActive(true);
                   }
               }

               foreach (GameObject go in LM)
               {
                   if (go.activeSelf == false)
                   {
                       go.SetActive(true);
                   }
               }
               animatorPDG.Play("PDG Return");

           }
           //LM
           if (hit.collider.gameObject.CompareTag("Le Mont-Saint-Michel") && lmClicked == false)
           {
               lmClicked = true;
               selectNo = 5;
               foreach (GameObject go in ET)
               {
                   if (go.activeSelf == true)
                   {
                       go.SetActive(false);
                   }
               }
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
               animatorLM.Play("LM Grow");
               Debug.Log("LM");
           }
           else if (hit.collider.gameObject.CompareTag("Le Mont-Saint-Michel") && lmClicked == true)
           {
               lmClicked = false;
               selectNo = 0;
               labelBG.SetActive(false);
               label.text = "";
               foreach (GameObject go in ET)
               {
                   if (go.activeSelf == false)
                   {
                       go.SetActive(true);
                   }
               }
               foreach (GameObject go in Bourges)
               {
                   if (go.activeSelf == false)
                   {
                       go.SetActive(true);
                   }
               }

               foreach (GameObject go in PDG)
               {
                   if (go.activeSelf == false)
                   {
                       go.SetActive(true);
                   }
               }
               animatorLM.Play("LM Return");

           }
       */
    }
}
/*IEnumerator DeactivateObjs()
{
    GameObject.FindGameObjectWithTag("Bourges").SetActive(false);
    GameObject.FindGameObjectWithTag("PDG").SetActive(false);
    GameObject.FindGameObjectWithTag("Le Mont").SetActive(false);
    yield return new WaitForSeconds(delay);
}
IEnumerator DeactivateObjs2()
{
    GameObject.FindGameObjectWithTag("Eiffel Tower").SetActive(false);
    GameObject.FindGameObjectWithTag("PDG").SetActive(false);
    GameObject.FindGameObjectWithTag("Le Mont").SetActive(false);
    yield return new WaitForSeconds(delay);
}
IEnumerator ActivateObjs()
{

    GameObject.FindGameObjectWithTag("Bourges").SetActive(true);

    GameObject.FindGameObjectWithTag("PDG").SetActive(true);

    GameObject.FindGameObjectWithTag("Le Mont").SetActive(true);

    yield return new WaitForSeconds(delay);
}
IEnumerator ActivateObjs2()
{

    GameObject.FindGameObjectWithTag("Eiffel Tower").SetActive(true);

    GameObject.FindGameObjectWithTag("PDG").SetActive(true);

    GameObject.FindGameObjectWithTag("Le Mont").SetActive(true);

    yield return new WaitForSeconds(delay);
}*/



