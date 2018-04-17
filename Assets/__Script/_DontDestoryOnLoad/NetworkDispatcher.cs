using CowProto;
using System;

/// <summary>
/// 网络模块消息分发
/// </summary>
public partial class Network : WakaSDK.IDispatcher
{
    private void EventRedirectWithoutResult(Action callback)
    {
        if (callback != null)
        {
            callback.Invoke();
        }
    }

    private bool EventRedirect<T>(Action<T> callback, T ev)
    {
        if (callback != null)
        {
            callback.Invoke(ev);
            return true;
        }
        return false;
    }

    public void ConnectFailed()
    {
        IsConnected = false;
        EventRedirectWithoutResult(OnConnectFailed);
    }

    public void Closed()
    {
        IsConnected = false;
        EventRedirectWithoutResult(OnClosed);
    }

    public void Connected()
    {
        IsConnected = true;
        EventRedirectWithoutResult(OnConnected);
    }

    public bool EventWelcome(Welcome ev)
    {
        return EventRedirect(OnWelcome, ev);
    }

    public bool EventLoginFailed(LoginFailed ev)
    {
        return EventRedirect(OnLoginFailed, ev);
    }

    public bool EventLoginSuccess(LoginSuccess ev)
    {
        return EventRedirect(OnLoginSuccess, ev);
    }

    public bool EventHallEntered(HallEntered ev)
    {
        return EventRedirect(OnHallEntered, ev);
    }

    public bool EventPlayerNumber(PlayerNumber ev)
    {
        return EventRedirect(OnPlayerNumber, ev);
    }

    public bool EventRecover(Recover ev)
    {
        return EventRedirect(OnRecover, ev);
    }

    public bool EventNiuniuCreateRoomFailed(NiuniuCreateRoomFailed ev)
    {
        return EventRedirect(OnNiuniuCreateRoomFailed, ev);
    }

    public bool EventNiuniuCreateRoomSuccess(NiuniuCreateRoomSuccess ev)
    {
        return EventRedirect(OnNiuniuCreateRoomSuccess, ev);
    }

    public bool EventNiuniuJoinRoomFailed(NiuniuJoinRoomFailed ev)
    {
        return EventRedirect(OnNiuniuJoinRoomFailed, ev);
    }

    public bool EventNiuniuJoinRoomSuccess(NiuniuJoinRoomSuccess ev)
    {
        return EventRedirect(OnNiuniuJoinRoomSuccess, ev);
    }

    public bool EventNiuniuLeftRoom(NiuniuLeftRoom ev)
    {
        return EventRedirect(OnNiuniuLeftRoom, ev);
    }

    public bool EventNiuniuUpdateRoom(NiuniuUpdateRoom ev)
    {
        return EventRedirect(OnNiuniuUpdateRoom, ev);
    }

    public bool EventNiuniuGameStarted(NiuniuGameStarted ev)
    {
        return EventRedirect(OnNiuniuGameStarted, ev);
    }

    public bool EventNiuniuRoundStarted(NiuniuRoundStarted ev)
    {
        return EventRedirect(OnNiuniuRoundStarted, ev);
    }

    public bool EventNiuniuDeadline(NiuniuDeadline ev)
    {
        return EventRedirect(OnNiuniuDeadline, ev);
    }

    public bool EventNiuniuUpdateRound(NiuniuUpdateRound ev)
    {
        return EventRedirect(OnNiuniuUpdateRound, ev);
    }

    public bool EventNiuniuRequireSpecifyBanker(NiuniuRequireSpecifyBanker ev)
    {
        return EventRedirect(OnNiuniuRequireSpecifyBanker, ev);
    }

    public bool EventNiuniuRequireGrab(NiuniuRequireGrab ev)
    {
        return EventRedirect(OnNiuniuRequireGrab, ev);
    }

    public bool EventNiuniuRequireGrabShow(NiuniuRequireGrabShow ev)
    {
        return EventRedirect(OnNiuniuRequireGrabShow, ev);
    }

    public bool EventNiuniuDeal4(NiuniuDeal4 ev)
    {
        return EventRedirect(OnNiuniuDeal4, ev);
    }

    public bool EventNiuniuRequireSpecifyRate(NiuniuRequireSpecifyRate ev)
    {
        return EventRedirect(OnNiuniuRequireSpecifyRate, ev);
    }

    public bool EventNiuniuDeal1(NiuniuDeal1 ev)
    {
        return EventRedirect(OnNiuniuDeal1, ev);
    }

    public bool EventNiuniuRoundClear(NiuniuRoundClear ev)
    {
        return EventRedirect(OnNiuniuRoundClear, ev);
    }

    public bool EventNiuniuGameFinally(NiuniuGameFinally ev)
    {
        return EventRedirect(OnNiuniuGameFinally, ev);
    }

    public bool EventRedCreateBagFailed(RedCreateBagFailed ev)
    {
        return EventRedirect(OnRedCreateBagFailed, ev);
    }

    public bool EventRedUpdateBagList(RedUpdateBagList ev)
    {
        return EventRedirect(OnRedUpdateBagList, ev);
    }

    public bool EventRedCreateBagSuccess(RedCreateBagSuccess ev)
    {
        return EventRedirect(OnRedCreateBagSuccess, ev);
    }

    public bool EventRedGrabFailed(RedGrabFailed ev)
    {
        return EventRedirect(OnRedGrabFailed, ev);
    }

    public bool EventRedGrabSuccess(RedGrabSuccess ev)
    {
        return EventRedirect(OnRedGrabSuccess, ev);
    }

    public bool EventRedDeadline(RedDeadline ev)
    {
        return EventRedirect(OnRedDeadline, ev);
    }

    public bool EventRedUpdateBag(RedUpdateBag ev)
    {
        return EventRedirect(OnRedUpdateBag, ev);
    }

    public bool EventRedHandsBagSettled(RedHandsBagSettled ev)
    {
        return EventRedirect(OnRedHandsBagSettled, ev);
    }

    public bool EventRedBagDestroyed(RedBagDestroyed ev)
    {
        return EventRedirect(OnRedBagDestroyed, ev);
    }

    public bool EventLever28CreateBagFailed(Lever28CreateBagFailed ev)
    {
        return EventRedirect(OnLever28CreateBagFailed, ev);
    }

    public bool EventLever28CreateBagSuccess(Lever28CreateBagSuccess ev)
    {
        return EventRedirect(OnLever28CreateBagSuccess, ev);
    }

    public bool EventLever28UpdateBagList(Lever28UpdateBagList ev)
    {
        return EventRedirect(OnLever28UpdateBagList, ev);
    }

    public bool EventLever28GrabFailed(Lever28GrabFailed ev)
    {
        return EventRedirect(OnLever28GrabFailed, ev);
    }

    public bool EventLever28GrabSuccess(Lever28GrabSuccess ev)
    {
        return EventRedirect(OnLever28GrabSuccess, ev);
    }

    public bool EventLever28Deadline(Lever28Deadline ev)
    {
        return EventRedirect(OnLever28Deadline, ev);
    }

    public bool EventLever28UpdateBag(Lever28UpdateBag ev)
    {
        return EventRedirect(OnLever28UpdateBag, ev);
    }

    public bool EventLever28BagDestroyed(Lever28BagDestroyed ev)
    {
        return EventRedirect(OnLever28BagDestroyed, ev);
    }

    public bool EventGomokuCreateRoomFailed(GomokuCreateRoomFailed ev)
    {
        return EventRedirect(OnGomokuCreateRoomFailed, ev);
    }

    public bool EventGomokuCreateRoomSuccess(GomokuCreateRoomSuccess ev)
    {
        return EventRedirect(OnGomokuCreateRoomSuccess, ev);
    }

    public bool EventGomokuJoinRoomFailed(GomokuJoinRoomFailed ev)
    {
        return EventRedirect(OnGomokuJoinRoomFailed, ev);
    }

    public bool EventGomokuJoinRoomSuccess(GomokuJoinRoomSuccess ev)
    {
        return EventRedirect(OnGomokuJoinRoomSuccess, ev);
    }

    public bool EventGomokuSetRoomCostFailed(GomokuSetRoomCostFailed ev)
    {
        return EventRedirect(OnGomokuSetRoomCostFailed, ev);
    }

    public bool EventGomokuUpdateRoom(GomokuUpdateRoom ev)
    {
        return EventRedirect(OnGomokuUpdateRoom, ev);
    }

    public bool EventGomokuLeft(GomokuLeft ev)
    {
        return EventRedirect(OnGomokuLeft, ev);
    }

    public bool EventGomokuStarted(GomokuStarted ev)
    {
        return EventRedirect(OnGomokuStarted, ev);
    }

    public bool EventGomokuUpdateRound(GomokuUpdateRound ev)
    {
        return EventRedirect(OnGomokuUpdateRound, ev);
    }

    public bool EventGomokuRequirePlay(GomokuRequirePlay ev)
    {
        return EventRedirect(OnGomokuRequirePlay, ev);
    }

    public bool EventGomokuUpdatePlayDeadline(GomokuUpdatePlayDeadline ev)
    {
        return EventRedirect(OnGomokuUpdatePlayDeadline, ev);
    }

    public bool EventGomokuLost(GomokuLost ev)
    {
        return EventRedirect(OnGomokuLost, ev);
    }

    public bool EventGomokuVictory(GomokuVictory ev)
    {
        return EventRedirect(OnGomokuVictory, ev);
    }
}
