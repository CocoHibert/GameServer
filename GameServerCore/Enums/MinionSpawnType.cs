namespace GameServerCore.Enums
{
    //佣兵出生类型
    public enum MinionSpawnType : byte
    {
        MINION_TYPE_MELEE = 0x00,   //近战
        MINION_TYPE_CASTER = 0x03,  //远程
        MINION_TYPE_CANNON = 0x02,  //炮车
        MINION_TYPE_SUPER = 0x01    //超级兵
    }
}