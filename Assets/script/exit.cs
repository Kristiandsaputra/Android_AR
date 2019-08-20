using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour {

    public void doExitGame()
    {
        Application.Quit();
    }
}
