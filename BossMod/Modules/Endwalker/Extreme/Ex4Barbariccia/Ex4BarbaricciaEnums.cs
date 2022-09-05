﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossMod.Endwalker.Extreme.Ex4Barbariccia
{
    public enum OID : uint
    {
        Boss = 0x39CE, // x1
        BarbaricciaShadow = 0x39CF, // x9
        Helper = 0x233C, // x31
        Tangle = 0x3973, // x4, fetters tethers players to one of these
        //_Gen_Actor39d4 = 0x39D4, // x1
        //_Gen_Exit = 0x1E850B, // x1, EventObj type
        //_Gen_MagitekArmor = 0x1EB702, // x4, EventObj type
        //_Gen_Actor1e8536 = 0x1E8536, // x1, EventObj type
        //_Gen_StiffBreeze = 0x39D0, // spawn during fight
    };

    public enum AID : uint
    {
        AutoAttack = 30072, // Boss->player, no cast, single-target
        Teleport = 30082, // Boss->location, no cast, single-target
        VoidAeroRaidwide = 30064, // Boss->self, 5.0s cast, raidwide
        VoidAeroTankbuster = 30065, // Boss->player, 5.0s cast, range 5 circle aoe tankbuster
        RagingStorm = 30066, // Boss->location, no cast, raidwide + teleport

        SavageBarberyDonut = 29797, // Boss->self, 6.0s cast, single-target, visual
        SavageBarberyDonutAOE = 30068, // Helper->self, 7.0s cast, range 6-20 donut
        SavageBarberyDonutSword = 30069, // Helper->self, 9.1s cast, range 20 circle
        SavageBarberyRect = 29833, // Boss->self, 6.0s cast, single-target, visual
        SavageBarberyRectAOE = 30074, // Helper->self, 7.0s cast, range 40 width 12 rect
        SavageBarberyRectSword = 30075, // Helper->self, 9.1s cast, range 20 circle
        //BrushWithDeathSavageBarbery = 30116, // Boss->self, no cast, single-target, visual ???
        HairRaidCone = 30076, // Boss->location, 6.0s cast, visual + teleport
        HairRaidConeAOE = 30077, // Helper->self, 8.0s cast, range 40 ?-degree cone
        HairRaidDonut = 30078, // Boss->self, 6.0s cast, single-target, visual
        HairRaidDonutAOE = 30079, // Helper->self, 8.0s cast, range 6-20 donut
        HairSpray = 30118, // Helper->players, 8.0s cast, range 5 circle spread
        DeadlyTwist = 30119, // Helper->players, 8.0s cast, range 6 circle shared

        TeasingTangles = 30121, // Boss->self, 4.0s cast, single-target, visual
        Tangle = 30123, // Helper->self, 4.6s cast, range 6 circle aoe
        TangleKnockback = 30124, // Helper->player, no cast, single-target, knockback 9
        TangleFail = 29567, // Helper->player, no cast, single-target, knockback 20 on people leaving tangle zone
        Fetters = 30128, // Helper->player, no cast, single-target, applies fetters status
        //BrushWithDeathTangle = 30115, // Boss->self, no cast, single-target, visual ???
        HairFlay = 29715, // Helper->players, 8.0s cast, range 10 circle spread
        Upbraid = 30120, // Helper->players, 8.0s cast, range 3 circle enumeration 2
        SecretBreeze = 30080, // Boss->self, 3.0s cast, single-target, visual
        SecretBreezeAOE = 29717, // Helper->self, 4.0s cast, range 40 45-degree cone aoe
        SecretBreezeProtean = 30081, // Helper->self, no cast, range 40 45-degree cone baited

        CurlingIron = 30130, // Boss->self, 5.0s cast, single-target, visual
        CurlingIronAOE = 30131, // Helper->self, no cast, raidwide
        Voidstrom = 30071, // Helper->self, no cast, range 6 circle, knockback 4 during curling iron
        //Catabasis = 30132, // Boss->self, no cast, single-target, visual ???
        //Catabasis = 29832, // Boss->self, no cast, single-target, visual ???
        Catabasis = 30070, // Helper->self, 8.0s cast, raidwide

        BrutalRush = 30083, // Boss->player, no cast, single-target, rushes 1-3
        BrutalRushLast = 30084, // Boss->player, no cast, single-target, rush 4
        BrutalGust = 30085, // BarbaricciaShadow->self, 2.0s cast, range 40 width 4 rect

        //BoulderBreak = 29570, // Boss->self, no cast, single-target, visual ???
        BoulderBreak = 29571, // Helper->players, 5.0s cast, range 6 circle shared tankbuster

        WarningGaleVisual = 30086, // Boss->self, no cast, single-target, visual ???
        WarningGale = 30087, // Helper->self, 5.0s cast, range 6 circle aoe in center
        WindingGaleVisual1 = 30088, // BarbaricciaShadow->location, no cast, single-target, teleport ???
        WindingGale = 29830, // Helper->self, 5.0s cast, range 9?-11 donut (spiral arm, 180 degree donut offset by ~outer radius?)
        WindingGaleCharge = 30089, // Helper->location, 2.5s cast, width 4 rect charge aoe
        WindingGaleChargeVisual = 30090, // BarbaricciaShadow->location, no cast, width 4 rect charge, visual
        WindingGaleVisual2 = 30091, // BarbaricciaShadow->location, no cast, single-target, visual
        //_Gen_BrushWithDeathWindingGale = 30117, // Boss->self, no cast, single-target, visual ???
        BoulderVisual = 30108, // Boss->self, no cast, single-target, visual ???
        Boulder = 30109, // Helper->location, 4.0s cast, range 10 circle puddle
        BrittleBoulder = 30110, // Helper->players, 3.0s cast, range 5 circle spread
        TornadoChainInner = 30092, // Helper->self, 4.0s cast, range 11 circle aoe
        TornadoChainOuter = 30093, // Helper->self, 6.5s cast, range 11-20 donut aoe
        TornadoChainVisualInner = 30094, // Boss->self, no cast, single-target, visual
        TornadoChainVisualOuter = 30095, // Boss->self, no cast, single-target, visual

        //_Gen_SavageBarbery = 29835, // Boss->self, 6.0s cast, single-target
        //_Gen_KnuckleDrum = 30103, // Boss->self, no cast, single-target
        //_Gen_SavageBarbery = 29796, // Boss->self, 6.0s cast, single-target
        //_Gen_KnuckleDrum = 30104, // Helper->self, no cast, range 40 circle
        //_Gen_KnuckleDrum = 30105, // Helper->self, no cast, range 40 circle
        //_Gen_BlowAway = 30101, // Boss->self, no cast, range 20 circle
        //_Gen_BlowAway = 30102, // Helper->self, 4.0s cast, range 6 circle
        //_Gen_BoldBoulder = 30106, // Boss->self, no cast, single-target
        //_Gen_Impact = 30111, // Boss->location, no cast, single-target
        //_Gen_Impact = 30113, // Helper->self, 6.2s cast, range 20 circle
        //_Gen_Impact = 30112, // Helper->self, 6.2s cast, range 6 circle
        //_Gen_BoldBoulder = 30107, // Helper->players, 8.0s cast, range 40 circle
        //_Gen_Trample = 30114, // Boss->players, no cast, range 6 circle
        //_Gen_SavageBarbery = 29798, // Boss->self, 6.0s cast, single-target
        //_Gen_TeasingTangles = 30122, // Boss->self, no cast, single-target
        //_Gen_BlusteryRuler = 30097, // Boss->self, no cast, single-target
        //_Gen_BlusteryRuler = 30096, // Helper->self, 5.0s cast, range 6 circle
        //_Gen_DryBlows = 30099, // Boss->self, no cast, range 20 circle
        //_Gen_Tousle = 30098, // 39D0->self, no cast, range 2 circle
        //_Gen_DryBlows = 30100, // Helper->location, 3.0s cast, range 3 circle
        //_Gen_IronOut = 30133, // Boss->self, no cast, single-target
        //_Gen_IronOut = 29781, // Helper->self, no cast, range 40 circle
        //_Gen_Entanglement = 30125, // Boss->self, 4.0s cast, single-target
        //_Gen_ = 30127, // Helper->player, no cast, single-target
        Maelstrom = 30142, // Boss->self, 9.0s cast, enrage
    };

    public enum TetherID : uint
    {
        Tangle = 199, // player->Tangle
        BrutalRush = 17, // player->Boss
        //_Gen_Tether_210 = 210, // player->player
    };
}