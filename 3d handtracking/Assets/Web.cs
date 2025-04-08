using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public static class DataHolder
{
    public static string downloadedText = "";
    public static string scoreText = "";
}



public class Web : MonoBehaviour
{   
    public GameObject LengthWrong;
    public GameObject LoginSuccess;
    public GameObject UDNE;
    public GameObject WrongCredentials;
    public GameObject UserAlready;
    public GameObject RegisterSuccess;
    public bool shouldShow = true;
    public string inputUsername;
    public string inputPassword;

    void Start()
    {
        // StartCoroutine(GetDate());
        //StartCoroutine(GetUser());
        //StartCoroutine(RegisterUser("chillBeatz","999999"));
        //Rank();
        LoginSuccess.SetActive(shouldShow);
    }

    public IEnumerator GetDate()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://API_IP/fruitninja/GetDate.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //show results as text
                Debug.Log(www.downloadHandler.text);
                //Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
    }
    public IEnumerator GetUser()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://API_IP/fruitninja/GetUser.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //show results as text
                Debug.Log(www.downloadHandler.text);
                //Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
    }
    public IEnumerator Login(string username, string password)
    {
        if(username.Length<1 || password.Length<3)
        {
            LengthWrong.SetActive(!LengthWrong.activeSelf);
            yield return new WaitForSeconds(2.0f);
            LengthWrong.SetActive(!LengthWrong.activeSelf);
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("loginUser", username);
            form.AddField("loginPass", password);
            inputUsername = username;
            inputPassword = password;


            using (UnityWebRequest www = UnityWebRequest.Post("http://API_IP/fruitninja/Login.php", form))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.downloadHandler.text);
                    if (www.downloadHandler.text == "Login Success.")
                    {
                        LoginSuccess.SetActive(!LoginSuccess.activeSelf);
                        yield return new WaitForSeconds(2.0f);
                        SceneManager.LoadScene("HowToPlay");
                    }
                    else if (www.downloadHandler.text == "Username does not exists")
                    {
                        UDNE.SetActive(!UDNE.activeSelf);
                        yield return new WaitForSeconds(2.0f);
                        UDNE.SetActive(!UDNE.activeSelf);
                    }
                    else if (www.downloadHandler.text == "Wrong Credentials.")
                    {
                        WrongCredentials.SetActive(!WrongCredentials.activeSelf);
                        yield return new WaitForSeconds(2.0f);
                        WrongCredentials.SetActive(!WrongCredentials.activeSelf);
                    }
                }
            }
        }
        
    }
    public IEnumerator RegisterUser(string username, string password)
    {   
        if(username.Length<1 || password.Length<3)
        {
            LengthWrong.SetActive(!LengthWrong.activeSelf);
            yield return new WaitForSeconds(2.0f);
            LengthWrong.SetActive(!LengthWrong.activeSelf);
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("loginUser", username);
            form.AddField("loginPass", password);


            using (UnityWebRequest www = UnityWebRequest.Post("http://API_IP/fruitninja/RegisterUser.php", form))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.downloadHandler.text);
                    if (www.downloadHandler.text == "Username is already taken.")
                    {
                        UserAlready.SetActive(!UserAlready.activeSelf);
                        yield return new WaitForSeconds(2.0f);
                        UserAlready.SetActive(!UserAlready.activeSelf);
                    }
                    else if (www.downloadHandler.text == "Creating user...New record created successfully")
                    {
                        RegisterSuccess.SetActive(!RegisterSuccess.activeSelf);
                        yield return new WaitForSeconds(2.0f);
                        RegisterSuccess.SetActive(!RegisterSuccess.activeSelf);
                    }
                }
            }
        }
    }
    public IEnumerator Score(int score)
    {
        WWWForm form = new WWWForm();

        form.AddField("score", score);
        form.AddField("loginUser", inputUsername);
        form.AddField("loginPass", inputPassword);


        using (UnityWebRequest www = UnityWebRequest.Post("http://API_IP/fruitninja/score.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {   
                DataHolder.scoreText = www.downloadHandler.text;
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
    public IEnumerator Rank()
    {
        WWWForm form = new WWWForm();

        using (UnityWebRequest www = UnityWebRequest.Post("http://API_IP/fruitninja/Rank.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                DataHolder.downloadedText = www.downloadHandler.text;
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}           