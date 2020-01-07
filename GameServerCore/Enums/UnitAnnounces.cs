namespace GameServerCore.Enums
{
    public enum UnitAnnounces : byte
    {
        DEATH = 0x04,                   //英雄死亡
        INHIBITOR_DESTROYED = 0x1F,     //召唤水晶：兵营
        INHIBITOR_ABOUT_TO_SPAWN = 0x20,
        INHIBITOR_SPAWNED = 0x21,
        TURRET_DESTROYED = 0x24,        //防御塔被摧毁
        SUMMONER_DISCONNECTED = 0x47,   //召唤师断开连接   
        SUMMONER_RECONNECTED = 0x48     //召唤师重新连接
    }
}