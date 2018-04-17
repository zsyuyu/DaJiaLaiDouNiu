using CowProto;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    /// <summary>
    /// 数据模型模块单例对象
    /// </summary>
    public static Model Instance;

    /// <summary>
    /// 推送信息
    /// </summary>
    public Welcome Welcome;

    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {

    }
}
