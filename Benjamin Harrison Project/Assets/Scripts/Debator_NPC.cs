using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debator_NPC : MonoBehaviour
{
    public GameObject alert;
    public GameObject challenge;

    public bool QuestsComplete() {
     for ( int i = 0; i < QuestSystem.main.Stages.Length; ++i ) {
         if (QuestSystem.main.Stages[i] == false) {
           return false;
         }
     }
 
     return true;
     }

    // Start is called before the first frame update
    void Start()
    {
        alert.SetActive(false);
        challenge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (QuestsComplete() == true)
            {
                challenge.SetActive(true);
            }
            else
            {
                alert.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
                challenge.SetActive(false);
                alert.SetActive(false);
        }
    }
}
