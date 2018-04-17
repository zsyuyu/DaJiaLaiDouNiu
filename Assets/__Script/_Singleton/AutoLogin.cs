using UnityEngine;

/// <summary>
/// 自动登陆管理
/// </summary>
public class AutoLogin
{
    /// <summary>
    /// 是否可以登陆
    /// </summary>
    static public bool CanLogin
    {
        get
        {
            return _Token.Length != 0;
        }
    }

    /// <summary>
    /// 登陆令牌
    /// </summary>
    static public string Token
    {
        get
        {
            return _Token;
        }
        set
        {
            PlayerPrefs.SetString("AutoLogin.Token", value);
            _Token = value;
        }
    }

    static private string _Token;

    static AutoLogin()
    {
        _Token = PlayerPrefs.GetString("AutoLogin.Token");
    }
}
