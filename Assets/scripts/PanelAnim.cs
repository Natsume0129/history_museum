using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnim : MonoBehaviour
{
    public AnimationCurve showCurve;
    public AnimationCurve hideCurve;
    public float animationSpeed;
    public GameObject panel;
    public bool isShowed= false;
    Rigidbody rb;
    public GameObject firstperson;

    public void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    IEnumerator ShowPanel(GameObject gameObject)
    {
        float timer = 0;
        while (timer<=1)
        {
            gameObject.transform.localScale= Vector3.one*showCurve.Evaluate(timer);
            timer += Time.deltaTime * animationSpeed;
            yield return null;

        }
    }

    IEnumerator HidePanel(GameObject gameObject)
    {
        float timer = 0;
        while (timer <= 1)
        {
            timer += Time.deltaTime * animationSpeed;
            gameObject.transform.localScale = timer <= 1 ? Vector3.one * hideCurve.Evaluate(timer) : Vector3.zero;
            yield return null;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
    


        
    }
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.E) && isShowed == false)
            {
            panel.SetActive(true);
            StartCoroutine(ShowPanel(panel));
            isShowed = true;
            print(firstperson.transform.localPosition);

        }
        else if (Input.GetKeyDown(KeyCode.Escape)&&isShowed==true) 
        {
            StartCoroutine(HidePanel(panel));
            isShowed = false;
        }
    }

}
