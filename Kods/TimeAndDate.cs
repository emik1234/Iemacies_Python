using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeAndDate : MonoBehaviour
{
    public TMP_Text time;
    public TMP_Text date;

    /// <summary>
    /// <c>Update()</c> Sets current date and time
    /// </summary>
    void Update()
    {
        string currentDate = System.DateTime.Now.ToString("dd-MM-yyyy");
        string currentTime = System.DateTime.Now.ToString("HH:mm");

        time.text = currentTime;
        date.text = currentDate;

    }
}
