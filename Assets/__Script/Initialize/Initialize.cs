using UnityEngine;
using UnityEngine.SceneManagement;

public class Initialize : MonoBehaviour
{
    /// <summary>
    /// 全局对象
    /// </summary>
    public GameObject DontDestoryOnLoad;

    private void Start()
    {
        DontDestroyOnLoad(DontDestoryOnLoad);

        SceneManager.LoadScene("Login");
    }

    private void Update()
    {

    }
}
