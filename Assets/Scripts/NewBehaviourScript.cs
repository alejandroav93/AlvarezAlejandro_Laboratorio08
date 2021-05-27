using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public bool active = false;
    public GameObject fx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            active = !active;
            fx.SetActive(active);
        }

    }

    void OnTriggerExit(Collider other)
    {
        active = !active;
        fx.SetActive(active);
    }

}
