namespace GameServerCore.Enums
{
    //伤害类型
    public enum DamageType : byte
    {
        DAMAGE_TYPE_PHYSICAL = 0x0,     //物理
        DAMAGE_TYPE_MAGICAL = 0x1,      //魔法
        DAMAGE_TYPE_TRUE = 0x2          //真实
    }
}