namespace GameServerCore.Enums
{
    //主要能力资源类型
    public enum PrimaryAbilityResourceType : byte
    {
        MANA = 0,       //魔法     
        ENERGY = 1,     //能量
        NONE = 2,       //无
        SHIELD = 3,     //护盾值
        BATTLE_FURY = 4,//战斗怒火 ：蛮王
        DRAGON_FURY = 5,//龙之怒火 ：龙女
        RAGE = 6,       //怒气
        HEAT = 7,       //热量 ： 兰博
        FEROCITY = 8,   //残暴 
        BLOOD_WELL = 9, //血井 ：剑魔
        WIND = 10,   
        OTHER = 11
    }
}