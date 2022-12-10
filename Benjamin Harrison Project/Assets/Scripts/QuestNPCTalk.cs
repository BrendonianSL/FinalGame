using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNPCTalk : MonoBehaviour
{
    public Dialouge dialouge;
    public Dialouge dialogueQuestMet1;
    public Dialouge dialogueQuestMet2;
    public Sprite npcPort;

    public int CaresAbout1;
    public int CaresAbout2;

    public int OptQuestProg1;
    public int OptQuestProg2;
    public int OptQuestProg3;

    public bool extraStage;
    public bool Text1Prog;
    public bool Text2Prog;
    public bool Text3Prog;

    void Update()
    {
        if (Player.notPaused && Input.GetKeyDown("space"))
        {
            if (QuestSystem.main.Stages[CaresAbout1] != true ) {
                if (Text1Prog == true) {QuestSystem.main.Stages[OptQuestProg1] = true;}
            FindObjectOfType<Player>().StartTalking();
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge, npcPort);
            }

            if (QuestSystem.main.Stages[CaresAbout1] == true ) {
                if (Text2Prog == true) {QuestSystem.main.Stages[OptQuestProg2] = true;}
            FindObjectOfType<Player>().StartTalking();
            FindObjectOfType<DialougeManager>().StartDialouge(dialogueQuestMet1, npcPort);
            }

            if (extraStage == true && QuestSystem.main.Stages[CaresAbout1] == true && QuestSystem.main.Stages[CaresAbout2] == true) {
                if (Text3Prog == true) {QuestSystem.main.Stages[OptQuestProg3] = true;}
            FindObjectOfType<Player>().StartTalking();
            FindObjectOfType<DialougeManager>().StartDialouge(dialogueQuestMet2, npcPort);
            }
        }
    }
}
