using CowProto;
using System;
using UnityEngine;
using WakaSDK;

/// <summary>
/// 网络模块
/// </summary>
public partial class Network : MonoBehaviour
{
    private void Start()
    {
        Instance = this;

        Supervisor.SetDispatcher(this);
    }

    private void Update()
    {
        if (!IsPause)
        {
            Supervisor.Loop();
        }
    }

    private void OnDestroy()
    {
        Supervisor.Close();
    }

    /// <summary>
    /// 服务器地址
    /// </summary>
    public static readonly string host = "103.60.164.154";
    /// <summary>
    /// 服务器端口
    /// </summary>
    public static readonly int port = 30011;

    /// <summary>
    /// 网络模块单例对象
    /// </summary>
    public static Network Instance;

    /// <summary>
    /// 已连接
    /// </summary>
    public bool IsConnected
    {
        get;
        private set;
    }

    /// <summary>
    /// 暂停
    /// </summary>
    public bool IsPause;

    /// <summary>
    /// 连接服务器
    /// </summary>
    public void Connect()
    {
        Supervisor.Connect(host, port);
    }

    /// <summary>
    /// 关闭连接
    /// </summary>
    public void Close()
    {
        Supervisor.Close();
    }

    /// <summary>
    /// 连接失败
    /// </summary>
    public Action OnConnectFailed;
    /// <summary>
    /// 连接成功
    /// </summary>
    public Action OnConnected;
    /// <summary>
    /// 连接关闭
    /// </summary>
    public Action OnClosed;

    /// <summary>
    /// 欢迎信息
    /// </summary>
    public Action<Welcome> OnWelcome;
    /// <summary>
    /// 登陆失败
    /// </summary>
    public Action<LoginFailed> OnLoginFailed;
    /// <summary>
    /// 登陆成功
    /// </summary>
    public Action<LoginSuccess> OnLoginSuccess;
    /// <summary>
    /// 进入大厅
    /// </summary>
    public Action<HallEntered> OnHallEntered;
    /// <summary>
    /// 在线玩家数量
    /// </summary>
    public Action<PlayerNumber> OnPlayerNumber;
    /// <summary>
    /// 断线恢复信息
    /// </summary>
    public Action<Recover> OnRecover;

    /// <summary>
    /// 创建房间失败
    /// </summary>
    public Action<NiuniuCreateRoomFailed> OnNiuniuCreateRoomFailed;
    /// <summary>
    /// 创建房间成功
    /// </summary>
    public Action<NiuniuCreateRoomSuccess> OnNiuniuCreateRoomSuccess;
    /// <summary>
    /// 加入房间失败
    /// </summary>
    public Action<NiuniuJoinRoomFailed> OnNiuniuJoinRoomFailed;
    /// <summary>
    /// 加入房间成功
    /// </summary>
    public Action<NiuniuJoinRoomSuccess> OnNiuniuJoinRoomSuccess;
    /// <summary>
    /// 离开了房间
    /// </summary>
    public Action<NiuniuLeftRoom> OnNiuniuLeftRoom;
    /// <summary>
    /// 更新房间信息
    /// </summary>
    public Action<NiuniuUpdateRoom> OnNiuniuUpdateRoom;
    /// <summary>
    /// 游戏开始
    /// </summary>
    public Action<NiuniuGameStarted> OnNiuniuGameStarted;
    /// <summary>
    /// 回合开始
    /// </summary>
    public Action<NiuniuRoundStarted> OnNiuniuRoundStarted;
    /// <summary>
    /// 倒计时开始
    /// </summary>
    public Action<NiuniuDeadline> OnNiuniuDeadline;
    /// <summary>
    /// 更新游戏信息
    /// </summary>
    public Action<NiuniuUpdateRound> OnNiuniuUpdateRound;
    /// <summary>
    /// 要求选择庄家
    /// </summary>
    public Action<NiuniuRequireSpecifyBanker> OnNiuniuRequireSpecifyBanker;
    /// <summary>
    /// 要求抢庄
    /// </summary>
    public Action<NiuniuRequireGrab> OnNiuniuRequireGrab;
    /// <summary>
    /// 要求抢庄动画
    /// </summary>
    public Action<NiuniuRequireGrabShow> OnNiuniuRequireGrabShow;
    /// <summary>
    /// 发四张牌
    /// </summary>
    public Action<NiuniuDeal4> OnNiuniuDeal4;
    /// <summary>
    /// 要求选择倍率
    /// </summary>
    public Action<NiuniuRequireSpecifyRate> OnNiuniuRequireSpecifyRate;
    /// <summary>
    /// 发最后一张牌
    /// </summary>
    public Action<NiuniuDeal1> OnNiuniuDeal1;
    /// <summary>
    /// 约战回合和流水回合结束
    /// </summary>
    public Action<NiuniuRoundClear> OnNiuniuRoundClear;
    /// <summary>
    /// 约战游戏结束
    /// </summary>
    public Action<NiuniuGameFinally> OnNiuniuGameFinally;

    /// <summary>
    /// 创建红包失败
    /// </summary>
    public Action<RedCreateBagFailed> OnRedCreateBagFailed;
    /// <summary>
    /// 创建红包成功
    /// </summary>
    public Action<RedCreateBagSuccess> OnRedCreateBagSuccess;
    /// <summary>
    /// 刷新红包列表
    /// </summary>
    public Action<RedUpdateBagList> OnRedUpdateBagList;
    /// <summary>
    /// 抢红包失败
    /// </summary>
    public Action<RedGrabFailed> OnRedGrabFailed;
    /// <summary>
    /// 抢红包成功
    /// </summary>
    public Action<RedGrabSuccess> OnRedGrabSuccess;
    /// <summary>
    /// 红包销毁时间
    /// </summary>
    public Action<RedDeadline> OnRedDeadline;
    /// <summary>
    /// 刷新红包信息
    /// </summary>
    public Action<RedUpdateBag> OnRedUpdateBag;
    /// <summary>
    /// 已发红包结算信息
    /// </summary>
    public Action<RedHandsBagSettled> OnRedHandsBagSettled;
    /// <summary>
    /// 红包销毁
    /// </summary>
    public Action<RedBagDestroyed> OnRedBagDestroyed;

    /// <summary>
    /// 创建红包失败
    /// </summary>
    public Action<Lever28CreateBagFailed> OnLever28CreateBagFailed;
    /// <summary>
    /// 创建红包成功
    /// </summary>
    public Action<Lever28CreateBagSuccess> OnLever28CreateBagSuccess;
    /// <summary>
    /// 刷新红包列表
    /// </summary>
    public Action<Lever28UpdateBagList> OnLever28UpdateBagList;
    /// <summary>
    /// 抢红包失败
    /// </summary>
    public Action<Lever28GrabFailed> OnLever28GrabFailed;
    /// <summary>
    /// 抢红包成功
    /// </summary>
    public Action<Lever28GrabSuccess> OnLever28GrabSuccess;
    /// <summary>
    /// 红包销毁时间
    /// </summary>
    public Action<Lever28Deadline> OnLever28Deadline;
    /// <summary>
    /// 刷新红包信息
    /// </summary>
    public Action<Lever28UpdateBag> OnLever28UpdateBag;
    /// <summary>
    /// 红包销毁
    /// </summary>
    public Action<Lever28BagDestroyed> OnLever28BagDestroyed;

    /// <summary>
    /// 创建房间失败
    /// </summary>
    public Action<GomokuCreateRoomFailed> OnGomokuCreateRoomFailed;
    /// <summary>
    /// 创建房间成功
    /// </summary>
    public Action<GomokuCreateRoomSuccess> OnGomokuCreateRoomSuccess;
    /// <summary>
    /// 加入房间失败
    /// </summary>
    public Action<GomokuJoinRoomFailed> OnGomokuJoinRoomFailed;
    /// <summary>
    /// 加入房间成功
    /// </summary>
    public Action<GomokuJoinRoomSuccess> OnGomokuJoinRoomSuccess;
    /// <summary>
    /// 设置学费失败
    /// </summary>
    public Action<GomokuSetRoomCostFailed> OnGomokuSetRoomCostFailed;
    /// <summary>
    /// 刷新房间信息
    /// </summary>
    public Action<GomokuUpdateRoom> OnGomokuUpdateRoom;
    /// <summary>
    /// 离开了房间
    /// </summary>
    public Action<GomokuLeft> OnGomokuLeft;
    /// <summary>
    /// 游戏开始
    /// </summary>
    public Action<GomokuStarted> OnGomokuStarted;
    /// <summary>
    /// 刷新游戏信息
    /// </summary>
    public Action<GomokuUpdateRound> OnGomokuUpdateRound;
    /// <summary>
    /// 要求走棋
    /// </summary>
    public Action<GomokuRequirePlay> OnGomokuRequirePlay;
    /// <summary>
    /// 走起倒计时
    /// </summary>
    public Action<GomokuUpdatePlayDeadline> OnGomokuUpdatePlayDeadline;
    /// <summary>
    /// 输
    /// </summary>
    public Action<GomokuLost> OnGomokuLost;
    /// <summary>
    /// 赢
    /// </summary>
    public Action<GomokuVictory> OnGomokuVictory;
}
