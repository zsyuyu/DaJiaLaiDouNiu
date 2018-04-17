using CowProto;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using WakaSDK;

public partial class Login : MonoBehaviour
{
    private void Start()
    {
        InitializeGameObject();
        InitializeEvent();
        AttachNetworkCallback();
        Connect();
    }

    private void AttachNetworkCallback()
    {
        var network = Network.Instance;

        network.OnConnectFailed += OnConnectFailed;
        network.OnConnected += OnConnected;
        network.OnClosed += OnClosed;
        network.OnWelcome += OnWelcome;
        network.OnLoginFailed += OnLoginFailed;
        network.OnLoginSuccess += OnLoginSuccess;
    }

    private void DetachNetworkCallback()
    {
        var network = Network.Instance;

        network.OnConnectFailed -= OnConnectFailed;
        network.OnConnected -= OnConnected;
        network.OnClosed -= OnClosed;
        network.OnWelcome -= OnWelcome;
        network.OnLoginFailed -= OnLoginFailed;
        network.OnLoginSuccess -= OnLoginSuccess;
    }

    private void Connect()
    {
        Network.Instance.Connect();
    }

    private void SaveEventWelcome(Welcome ev)
    {
        Model.Instance.Welcome = ev;
    }

    private void SaveToken(string token)
    {
        AutoLogin.Token = token;
    }

    private bool TryAutoLogin()
    {
        if (!AutoLogin.CanLogin)
        {
            return false;
        }

        Supervisor.PostTokenLogin(new TokenLogin
        {
            Token = AutoLogin.Token
        });

        return true;
    }

    private IEnumerator ShowConnectingAnimationAndReconnect()
    {
        ShowConnectingAnimation();
        yield return new WaitForSeconds(3.0f);
        Connect();
    }


    private void ShowLogin()
    {
        ShowWechatLogin();
        if (Model.Instance.Welcome.Exts["ios"] == "true")
        {
            ShowVisitorLogin();
        }
    }

    private void OnConnectFailed()
    {
        StartCoroutine(ShowConnectingAnimationAndReconnect());
    }

    private void OnClosed()
    {
        StartCoroutine(ShowConnectingAnimationAndReconnect());
    }

    private void OnConnected()
    {
        HideConnectingAnimation();
    }

    private void OnWelcome(Welcome ev)
    {
        SaveEventWelcome(ev);

        if (!TryAutoLogin())
        {
            ShowLogin();
        }
    }

    private void OnLoginFailed(LoginFailed ev)
    {
        ShowLogin();
    }

    private void OnLoginSuccess(LoginSuccess ev)
    {
        SaveToken(ev.Token);
        DetachNetworkCallback();
        SceneManager.LoadScene("Hall");
    }

    private void OnClickWechatLogin()
    {
        // TODO: 使用ShareSDK完成微信登陆
    }

    private void OnClickVisitorLogin()
    {
        Supervisor.PostWechatLogin(new WechatLogin
        {
            WechatUid = "_visitor_" + SystemInfo.deviceUniqueIdentifier,
            Nickname = "游客",
            Head = "",
        });
    }
}
