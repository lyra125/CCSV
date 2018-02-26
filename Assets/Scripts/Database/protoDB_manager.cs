using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class protoDB_manager : MonoBehaviour {

    string serverURL = "siteground.com";    // Database host
    string activeDB = "rongkaig";           // Database to use
    string keyDB = "xzNDoMgeww2t8Ndf";      // What's this?

    string userDB = "rongkaig_ccsv";        // Database User
    string passDB = "ccsv1357924680";       // Database Password

    string newUserURL = "http://rongkaiguo.com/ccsv/register_user.php";     // Used to create a user in the first place; Pass "username" and "password" as POST variables, status string returned
    string verifyURL = "http://rongkaiguo.com/ccsv/user_login.php";         // Pass "username" and "password" as POST variables, status string returned

    string usernameObj = "lyra";
    string passwordObj = "apples";

    string verifiedData;

    // Use this for initialization
    IEnumerator Start () {

        Debug.Log("program start");
        //RegisterNewUser();

        Debug.Log("creating form");
        WWWForm form = new WWWForm();

        Debug.Log("adding feilds");
        form.AddField("username", usernameObj);
        form.AddField("password", passwordObj);

        WWW www = new WWW(newUserURL, form);
        //var www = UnityWebRequest.Post("http://rongkaiguo.com/ccsv/user_login.php", form);
        Debug.Log("form completed");

        yield return www;
        Debug.Log("form sent");

        verifiedData = www.text;
        print(verifiedData);
        Debug.Log(www.text);

        Debug.Log("registered user");
        VerifyUser();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator RegisterNewUser()
    {
        Debug.Log("creating form");
        WWWForm form = new WWWForm();

        Debug.Log("adding feilds");
        form.AddField("username", usernameObj);
        form.AddField("password", passwordObj);

        WWW www = new WWW(newUserURL, form);
        //var www = UnityWebRequest.Post("http://rongkaiguo.com/ccsv/user_login.php", form);
        Debug.Log("form completed");

        yield return www;
        Debug.Log("form sent");

        verifiedData = www.text;
        print(verifiedData);
        Debug.Log(www.text);
    }

    private void VerifyUser()
    {
        Debug.Log("" + verifiedData);
    }
}
