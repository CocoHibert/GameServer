namespace GameServerCore.Enums
{
    public enum DamageText : byte
    {
        DAMAGE_TEXT_INVULNERABLE = 0x0, //无敌
        DAMAGE_TEXT_DODGE = 0x2,    //闪避
        DAMAGE_TEXT_CRITICAL = 0x3, //暴击
        DAMAGE_TEXT_NORMAL = 0x4,   //正常
        DAMAGE_TEXT_MISS = 0x5      //丢失
    }
}