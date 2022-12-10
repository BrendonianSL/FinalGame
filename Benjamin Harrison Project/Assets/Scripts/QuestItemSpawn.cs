using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemSpawn : MonoBehaviour
{

    public GameObject gameObject;
    public int stageToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (QuestSystem.main.Stages[stageToSpawn] == true) {
            gameObject.SetActive(true);
        }
    }
}
