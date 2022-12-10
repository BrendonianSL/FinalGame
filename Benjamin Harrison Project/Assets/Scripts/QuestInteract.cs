using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestInteract : MonoBehaviour
{
    public Dialouge dialouge;
    public Sprite npcPort;
    public GameObject gameObject;

    public int QuestObjNumber;

    void Update()
    {
        if (Player.notPaused && Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
            QuestSystem.main.Stages[QuestObjNumber] = true;
            FindObjectOfType<Player>().StartTalking();
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge, npcPort);
        }
    }
}
