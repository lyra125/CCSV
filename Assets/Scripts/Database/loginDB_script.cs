using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loginDB_script : MonoBehaviour
{
    public string newUserURL = "http://rongkaiguo.com/ccsv/register_user.php";

    public Button submitButton;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Start up");

        Button b = GameObject.Find("Submit").GetComponent<Button>();
        b.onClick.AddListener(submit);
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void submit()
    {
        Debug.Log("Submitted");
        StartCoroutine(RunRegistration());

        SceneManager.LoadScene("gameStart", LoadSceneMode.Single);
    }


    public IEnumerator RunRegistration()
    {
        Debug.Log("Registering User");
        var form = new WWWForm();

        var uname = GameObject.Find("Username").GetComponent<InputField>().text;
        var pword = GameObject.Find("Password").GetComponent<InputField>().text;

        Debug.Log(uname);
        Debug.Log(pword);

        form.AddField("username", uname);
        form.AddField("password", pword);

        var www = new WWW(newUserURL, form);
        yield return www;

        Debug.Log(www.text);


    }
}