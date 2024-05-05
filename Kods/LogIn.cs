using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Drawing.Printing;
using UnityEngine.SceneManagement;

public class LogIn : MonoBehaviour
{
    [SerializeField] private TMP_InputField username;
    [SerializeField] private TMP_InputField password; 
    [SerializeField] SQLiteDB db;

    [SerializeField] GameObject logInBox;
    [SerializeField] GameObject registerBox;

    [SerializeField] private TMP_InputField register_username;
    [SerializeField] private TMP_InputField register_password;
    [SerializeField] TMP_Text alert;

    string currentId;

    // Start is called before the first frame update
    void Start()
    {
        logInBox.SetActive(true);
        registerBox.SetActive(false);
    }

    /// <summary>
    /// <c>CheckCredentials()</c>Checks if login credentials are correct
    /// </summary>
    public void CheckCredentials() {
        bool valid = db.CheckAccount(username.text, password.text);
        
        if(valid) {
            currentId = db.CurrentID(username.text);
            PlayerPrefs.SetString("CurrentID", currentId);
            SceneManager.LoadScene("PC");
            
        } else {
            StartCoroutine(Alert("Nepareizs lietotājvārds un/vai parole!"));
        }
    }

    /// <summary>
    /// <c>Alert()</c>Shows up an alert on screen
    /// </summary>
    /// <param name="text">Text to show in the alarm</param>
    private IEnumerator Alert(string text) {
        alert.text = text;
        alert.color = Color.red;
        alert.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        alert.gameObject.SetActive(false);
    }

    /// <summary>
    /// <c>ShowRegisterBox()</c>Displays register box
    /// </summary>
    public void ShowRegisterBox() {
        logInBox.SetActive(false);
        registerBox.SetActive(true);
    }

    /// <summary>
    /// <c>ShowLoginBox()</c>Displays login box
    /// </summary>
    public void ShowLoginBox() {
        registerBox.SetActive(false);
        logInBox.SetActive(true);
    }

    /// <summary>
    /// <c>Register()</c>Adds new user's data to database
    /// </summary>
    public void Register() {
        db.CallAddUser(register_username.text, register_password.text);
    }
}
