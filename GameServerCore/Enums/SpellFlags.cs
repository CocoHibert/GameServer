using System;

namespace GameServerCore.Enums
{
    //技能特点
    [Flags]
    public enum SpellFlags : uint
    {
        AutoCast = 0x2,                     //自动施法
        InstantCast = 0x4,                  //立即施法
        PersistThroughDeath = 0x8,          //施法直到死亡

        NonDispellable = 0x10,              //不可驱散
        NoClick = 0x20,                     //
        AffectImportantBotTargets = 0x40,   //影响重要机器人目标
        AllowWhileTaunted = 0x80,

        NotAffectZombie = 0x100,
        AffectUntargetable = 0x200,     //影响不可选择
        AffectEnemies = 0x400,          //影响敌军
        AffectFriends = 0x800,          //影响友军

        AffectNeutral = 0x4000,         //影响中立
        AffectAllSides = 0x4C00,        //影响所有阵营
        AffectBuildings = 0x1000,       //影响建筑
        AffectMinions = 0x8000,         //影响士兵
        NotAffectSelf = 0x2000,         //不影响自己

        AffectHeroes = 0x10000,         //影响英雄
        AffectTurrets = 0x20000,        //影响防御塔
        AffectAllUnitTypes = 0x38000,   //影响所有单位类型
        AlwaysSelf = 0x40000,           //
        AffectDead = 0x80000,

        AffectNotPet = 0x100000,
        AffectBarracksOnly = 0x200000,
        IgnoreVisibilityCheck = 0x400000,   //忽视可见性检测
        NonTargetableAlly = 0x800000,

        NonTargetableEnemy = 0x1000000,
        TargetableToAll = 0x2000000,
        NonTargetableAll = 0x1800000,
        AffectWards = 0x4000000,
        AffectUseable = 0x8000000,

        IgnoreAllyMinion = 0x10000000,      //忽略所有佣兵
        IgnoreEnemyMinion = 0x20000000,     //忽略敌方佣兵
        IgnoreLaneMinion = 0x40000000,      //忽略
        IgnoreClones = 0x80000000,
    }
}