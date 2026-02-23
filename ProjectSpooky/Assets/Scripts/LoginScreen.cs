using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class LoginScreen : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;

    public string targetUsername;
    public string targetPassword;

    public UnityEvent OnLoginPass;
    public UnityEvent OnLoginFail;

    public void Login()
    {
        if(targetUsername == username.text && targetPassword == password.text)
        {
            OnLoginPass?.Invoke();
            return;
        }

        OnLoginFail?.Invoke();
    }
}
