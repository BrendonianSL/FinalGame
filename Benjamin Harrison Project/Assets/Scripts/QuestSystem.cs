using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{

    public bool[] Stages;
    public static QuestSystem main;

    void Awake() {
        main = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
