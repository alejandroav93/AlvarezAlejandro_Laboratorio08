using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RC : MonoBehaviour
{
    public string text = "Table";
    public Text myText;
   // public float fadeTime = 10.0f;
    public bool displayInfo;
    // Start is called before the first frame update
    LevelManager manager;
    void Start()
    {

        myText = GameObject.Find("Text").GetComponent<Text>();
        myText.color = Color.clear;
        manager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()

    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray camRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hitInfo;
        if (Physics.Raycast(camRay, out hitInfo))
        {
            if (hitInfo.collider.CompareTag("Chair"))
            {
                text = "Chair";
                displayInfo = true;
                FadeText();
            }
            if (hitInfo.collider.CompareTag("Table"))
            {
                text = "Table";
                displayInfo = true;
                FadeText();
            }
            if (hitInfo.collider.CompareTag("Sofa"))
            {
                text = "Sofa";
                displayInfo = true;
                FadeText();
            }
            if (hitInfo.collider.CompareTag("Untagged"))
            {
                displayInfo = false;
                FadeText();
            }
            if (hitInfo.collider.CompareTag("Closet"))
            {
                text = "Closet";
                displayInfo = true;
                FadeText();
            }
        }

        /*
        Debug.DrawRay(camRay.origin, camRay.direction, Color.red);
            */
        /*
        RaycastHit hitInfo;

        if(Physics.Raycast(transform.position, Vector3.down, out hitInfo, 3)){
            hitInfo.collider.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        */

        /*
        Color hit = Physics.Raycast(transform.position, Vector3.down, 3) ?
            Color.green : Color.red;
        Debug.DrawRay(transform.position, Vector3.down * 3, hit);
        */
    }
    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = text;
            myText.color = Color.white;
          //  myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        if (!displayInfo)
        {
            myText.color = Color.clear;
            //myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);

        }
    }

}
