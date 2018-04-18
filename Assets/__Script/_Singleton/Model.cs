using CowProto;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 全局数据模块
/// </summary>
public class Model
{
    /// <summary>
    /// 客服
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 创建新对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="wechat"></param>
        public Customer(string name, string wechat)
        {
            Name = name;
            Wechat = wechat;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// 微信
        /// </summary>
        public readonly string Wechat;
    }

    /// <summary>
    /// 推送URL数据
    /// </summary>
    public class WelcomeUrls
    {
        private Welcome welcome = null;

        /// <summary>
        /// 创建新对象
        /// </summary>
        /// <param name="ev">Welcome推送数据</param>
        public WelcomeUrls(Welcome ev)
        {
            welcome = ev;
        }

        /// <summary>
        /// Android下载地址
        /// </summary>
        public string AndroidDownload
        {
            get
            {
                return welcome.Urls["android_download"];
            }
        }
        /// <summary>
        /// iOS下载地址
        /// </summary>
        public string IOSDownload
        {
            get
            {
                return welcome.Urls["ios_download"];
            }
        }
        /// <summary>
        /// 代理后台地址
        /// </summary>
        public string Supervisor
        {
            get
            {
                return welcome.Urls["supervisor"];
            }
        }
        /// <summary>
        /// 充值地址
        /// </summary>
        public string Recharge
        {
            get
            {
                return welcome.Urls["recharge"];
            }
        }
    }

    /// <summary>
    /// 推送公告数据
    /// </summary>
    public class WelcomeNotices
    {
        private Welcome welcome = null;

        /// <summary>
        /// 创建新对象
        /// </summary>
        /// <param name="ev">Welcome推送数据</param>
        public WelcomeNotices(Welcome ev)
        {
            welcome = ev;
        }

        /// <summary>
        /// 健康游戏公告
        /// </summary>
        public string GAPP
        {
            get
            {
                return welcome.Notices["gapp"];
            }
        }
        /// <summary>
        /// 滚动公告
        /// </summary>
        public string Roll
        {
            get
            {
                return welcome.Notices["roll"];
            }
        }
    }

    /// <summary>
    /// 推送扩展数据
    /// </summary>
    public class WelcomeExts
    {
        private Welcome welcome = null;

        /// <summary>
        /// 创建新对象
        /// </summary>
        /// <param name="ev">Welcome推送数据</param>
        public WelcomeExts(Welcome ev)
        {
            welcome = ev;
        }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version
        {
            get
            {
                return welcome.Exts["ver"];
            }
        }
        /// <summary>
        /// iOS审核
        /// </summary>
        public bool Ios
        {
            get
            {
                return welcome.Exts["ios"] == "true";
            }
        }
    }

    /// <summary>
    /// 推送信息
    /// </summary>
    public static Welcome Welcome = new Welcome();

    /// <summary>
    /// 推送信息：客服列表
    /// </summary>
    public static List<Customer> Customers
    {
        get
        {
            var value = from x in Welcome.Customers
                        select new Customer(x.Name, x.Wechat);
            return value.ToList();
        }
    }

    /// <summary>
    /// 推送信息：地址
    /// </summary>
    public static WelcomeUrls Urls
    {
        get
        {
            return new WelcomeUrls(Welcome);
        }
    }

    /// <summary>
    /// 推送信息：公告
    /// </summary>
    public static WelcomeNotices Notices
    {
        get
        {
            return new WelcomeNotices(Welcome);
        }
    }

    /// <summary>
    /// 推送信息：扩展
    /// </summary>
    public static WelcomeExts Exts
    {
        get
        {
            return new WelcomeExts(Welcome);
        }
    }

    /// <summary>
    /// 在线人数
    /// </summary>
    public static int PlayerNumber;
}
