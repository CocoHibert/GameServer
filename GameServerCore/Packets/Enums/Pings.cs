namespace GameServerCore.Packets.Enums
{
    //玩家间Ping信号
    public enum Pings : byte
    {
        PING_DEFAULT = 0,       //默认
        PING_DANGER = 2,        //危险
        PING_MISSING = 3,       //消失
        PING_ON_MY_WAY = 4,     //在路上
        PING_ASSIST = 6         //请求协助
    }
}