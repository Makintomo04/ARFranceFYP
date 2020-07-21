using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelect : MonoBehaviour
{
    //private Text label;
    //private GameObject labelBG;
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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit1;
            if (Physics.Raycast(ray1, out hit1) && hit1.collider.gameObject.CompareTag("Eiffel Tower")) /*|| (Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2)*/
            {
                if (etClicked == false)
                {
                    selectNo = 1;
                    etClicked = true;
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
                    Debug.Log("ET");
                    animatorET.Play("ET Grow");
                }
                else if (etClicked == true)
                {
                    etClicked = false;
                    selectNo = 0;
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

            }
        }
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;
        if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Eiffel Tower")) /*|| (Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2)*/
        {
            if (etClicked == false) {
                selectNo = 1;
                etClicked = true;
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

                Debug.Log("ET");
                animatorET.Play("ET Grow");
            }
            else if (etClicked == true)
            {
                etClicked = false;
                selectNo = 0;
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
        }
            
            if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Bourges") && bClicked == false)
            {
                bClicked = true;
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
                animatorB.Play("B Grow");

                Debug.Log("B");
            }

            else if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Bourges") && bClicked == true)
            {
                bClicked = false;
                selectNo = 0;
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
                animatorB.Play("B Return");

            }
            if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Pont du Gard") && pdgClicked == false)
            {
                //labelBG.SetActive(true);
                //label.text = hit.transform.tag;
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
            else if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Pont du Gard") && pdgClicked == true)
            {
                pdgClicked = false;
                selectNo = 0;
                //labelBG.SetActive(false);
                //label.text = "";
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
            if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Le Mont-Saint-Michel") && lmClicked == false)
            {
              //  labelBG.SetActive(true);
              //  label.text = hit.transform.tag;
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
            else if (Input.GetTouch(0).phase == TouchPhase.Began && Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Le Mont-Saint-Michel") && lmClicked == true)
            {
                lmClicked = false;
                selectNo = 0;
               // labelBG.SetActive(false);
               // label.text = "";
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



