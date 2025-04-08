using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login: MonoBehaviour
{      
    public InputField accountField;
    public InputField passwordField;
    public Button submitButton;
    public Button RegisterButton;

    void Start()
    {   
        accountField.characterLimit = 8;
        passwordField.characterLimit = 10;

        submitButton.onClick.AddListener(() => {
            StartCoroutine(Main.Instance.Web.Login(accountField.text, passwordField.text));
        });
        RegisterButton.onClick.AddListener(() => {
            StartCoroutine(Main.Instance.Web.RegisterUser(accountField.text, passwordField.text));
        });
        
        //SceneManager.LoadScene("HowToPlay");  //略過註冊
        
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Login : MonoBehaviour
{   
    int flag = 1;
    public InputField accountField;
    public InputField passwordField;
    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());

    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("php side catch word", accountField.text);         //need change php side catch word by username
        form.AddField("php side catch word", passwordField.text);         //need change php side catch word by password

        using (UnityWebRequest www = UnityWebRequest.Post("https://www.my-server.com/myform", form))        //need change php URL
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");

                if(flag == 1)
                {
                    Application.LoadLevel("SampleScene");
                }
            }
        }
    }
}*/
