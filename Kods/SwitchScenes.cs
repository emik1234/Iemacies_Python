using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{   
    /// <summary>
    /// <c>TurnOff()</c> Loads the scene "TurnedOff"
    /// </summary>
    public void TurnOff()
    {
        SceneManager.LoadScene("TurnedOff");
    }

    /// <summary>
    /// <c>TurnOn()</c> Loads the scene "PC"
    /// </summary>
    public void TurnOn()
    {
        SceneManager.LoadScene("PC");
    }
}
