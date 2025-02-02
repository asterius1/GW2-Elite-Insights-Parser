﻿using System.Collections.Generic;
using static GW2EIEvtcParser.ParserHelper;

namespace GW2EIEvtcParser.ParserHelpers
{
    internal static class ParserIcons
    {
        /// <summary>
        /// Default icon in case of unknown profession.
        /// </summary>
        public const string UnknownProfessionIcon = "https://i.imgur.com/UbvyFSt.png";

        /// <summary>
        /// Default icon in case of unknown NPC.
        /// </summary>
        public const string UnknownNPCIcon = "https://i.imgur.com/nSYuby8.png";

        /// <summary>
        /// Generic enemy icon.
        /// </summary>
        public const string GenericEnemyIcon = "https://i.imgur.com/HuJHqRZ.png";

        // High Resolution Icons 200px
        private const string HighResUntamed = "https://wiki.guildwars2.com/images/3/33/Untamed_tango_icon_200px.png";
        private const string HighResSoulbeast = "https://wiki.guildwars2.com/images/f/f6/Soulbeast_tango_icon_200px.png";
        private const string HighResDruid = "https://wiki.guildwars2.com/images/6/6d/Druid_tango_icon_200px.png";
        private const string HighResRanger = "https://wiki.guildwars2.com/images/5/51/Ranger_tango_icon_200px.png";
        private const string HighResMechanist = "https://wiki.guildwars2.com/images/8/8a/Mechanist_tango_icon_200px.png";
        private const string HighResHolosmith = "https://wiki.guildwars2.com/images/a/ae/Holosmith_tango_icon_200px.png";
        private const string HighResScrapper = "https://wiki.guildwars2.com/images/3/3a/Scrapper_tango_icon_200px.png";
        private const string HighResEngineer = "https://wiki.guildwars2.com/images/2/2f/Engineer_tango_icon_200px.png";
        private const string HighResSpecter = "https://wiki.guildwars2.com/images/e/eb/Specter_tango_icon_200px.png";
        private const string HighResDeadeye = "https://wiki.guildwars2.com/images/b/b0/Deadeye_tango_icon_200px.png";
        private const string HighResDaredevil = "https://wiki.guildwars2.com/images/c/ca/Daredevil_tango_icon_200px.png";
        private const string HighResThief = "https://wiki.guildwars2.com/images/1/19/Thief_tango_icon_200px.png";
        private const string HighResCatalyst = "https://wiki.guildwars2.com/images/9/92/Catalyst_tango_icon_200px.png";
        private const string HighResWeaver = "https://wiki.guildwars2.com/images/3/31/Weaver_tango_icon_200px.png";
        private const string HighResTempest = "https://wiki.guildwars2.com/images/9/90/Tempest_tango_icon_200px.png";
        private const string HighResElementalist = "https://wiki.guildwars2.com/images/a/a0/Elementalist_tango_icon_200px.png";
        private const string HighResVirtuoso = "https://wiki.guildwars2.com/images/c/cd/Virtuoso_tango_icon_200px.png";
        private const string HighResMirage = "https://wiki.guildwars2.com/images/a/a9/Mirage_tango_icon_200px.png";
        private const string HighResChronomancer = "https://wiki.guildwars2.com/images/8/8b/Chronomancer_tango_icon_200px.png";
        private const string HighResMesmer = "https://wiki.guildwars2.com/images/7/73/Mesmer_tango_icon_200px.png";
        private const string HighResHarbinger = "https://wiki.guildwars2.com/images/b/b3/Harbinger_tango_icon_200px.png";
        private const string HighResScourge = "https://wiki.guildwars2.com/images/8/8a/Scourge_tango_icon_200px.png";
        private const string HighResReaper = "https://wiki.guildwars2.com/images/9/95/Reaper_tango_icon_200px.png";
        private const string HighResNecromancer = "https://wiki.guildwars2.com/images/c/cd/Necromancer_tango_icon_200px.png";
        private const string HighResBladesworn = "https://wiki.guildwars2.com/images/c/c1/Bladesworn_tango_icon_200px.png";
        private const string HighResSpellbreaker = "https://wiki.guildwars2.com/images/7/78/Spellbreaker_tango_icon_200px.png";
        private const string HighResBerserker = "https://wiki.guildwars2.com/images/8/80/Berserker_tango_icon_200px.png";
        private const string HighResWarrior = "https://wiki.guildwars2.com/images/d/db/Warrior_tango_icon_200px.png";
        private const string HighResWillbender = "https://wiki.guildwars2.com/images/5/57/Willbender_tango_icon_200px.png";
        private const string HighResFirebrand = "https://wiki.guildwars2.com/images/7/73/Firebrand_tango_icon_200px.png";
        private const string HighResDragonhunter = "https://wiki.guildwars2.com/images/1/1f/Dragonhunter_tango_icon_200px.png";
        private const string HighResGuardian = "https://wiki.guildwars2.com/images/6/6c/Guardian_tango_icon_200px.png";
        private const string HighResVindicator = "https://wiki.guildwars2.com/images/f/f0/Vindicator_tango_icon_200px.png";
        private const string HighResRenegade = "https://wiki.guildwars2.com/images/b/bc/Renegade_tango_icon_200px.png";
        private const string HighResHerald = "https://wiki.guildwars2.com/images/c/c7/Herald_tango_icon_200px.png";
        private const string HighResRevenant = "https://wiki.guildwars2.com/images/a/a8/Revenant_tango_icon_200px.png";

        // Base Resolution Icons 20px
        private const string BaseResUntamed = "https://wiki.guildwars2.com/images/thumb/3/33/Untamed_tango_icon_200px.png/20px-Untamed_tango_icon_200px.png";
        private const string BaseResSoulbeast = "https://wiki.guildwars2.com/images/7/7c/Soulbeast_tango_icon_20px.png";
        private const string BaseResDruid = "https://wiki.guildwars2.com/images/d/d2/Druid_tango_icon_20px.png";
        private const string BaseResRanger = "https://wiki.guildwars2.com/images/4/43/Ranger_tango_icon_20px.png";
        private const string BaseResMechanist = "https://wiki.guildwars2.com/images/thumb/8/8a/Mechanist_tango_icon_200px.png/20px-Mechanist_tango_icon_200px.png";
        private const string BaseResHolosmith = "https://wiki.guildwars2.com/images/2/28/Holosmith_tango_icon_20px.png";
        private const string BaseResScrapper = "https://wiki.guildwars2.com/images/3/3a/Scrapper_tango_icon_200px.png";
        private const string BaseResEngineer = "https://wiki.guildwars2.com/images/2/27/Engineer_tango_icon_20px.png";
        private const string BaseResSpecter = "https://wiki.guildwars2.com/images/5/5c/Specter_tango_icon_20px.png";
        private const string BaseResDeadeye = "https://wiki.guildwars2.com/images/c/c9/Deadeye_tango_icon_20px.png";
        private const string BaseResDaredevil = "https://wiki.guildwars2.com/images/e/e1/Daredevil_tango_icon_20px.png";
        private const string BaseResThief = "https://wiki.guildwars2.com/images/7/7a/Thief_tango_icon_20px.png";
        private const string BaseResCatalyst = "https://wiki.guildwars2.com/images/d/d5/Catalyst_tango_icon_20px.png";
        private const string BaseResWeaver = "https://wiki.guildwars2.com/images/f/fc/Weaver_tango_icon_20px.png";
        private const string BaseResTempest = "https://wiki.guildwars2.com/images/4/4a/Tempest_tango_icon_20px.png";
        private const string BaseResElementalist = "https://wiki.guildwars2.com/images/a/aa/Elementalist_tango_icon_20px.png";
        private const string BaseResVirtuoso = "https://wiki.guildwars2.com/images/6/62/Virtuoso_tango_icon_20px.png";
        private const string BaseResMirage = "https://wiki.guildwars2.com/images/d/df/Mirage_tango_icon_20px.png";
        private const string BaseResChronomancer = "https://wiki.guildwars2.com/images/f/f4/Chronomancer_tango_icon_20px.png";
        private const string BaseResMesmer = "https://wiki.guildwars2.com/images/6/60/Mesmer_tango_icon_20px.png";
        private const string BaseResHarbinger = "https://wiki.guildwars2.com/images/7/7f/Harbinger_tango_icon_20px.png";
        private const string BaseResScourge = "https://wiki.guildwars2.com/images/0/06/Scourge_tango_icon_20px.png";
        private const string BaseResReaper = "https://wiki.guildwars2.com/images/1/11/Reaper_tango_icon_20px.png";
        private const string BaseResNecromancer = "https://wiki.guildwars2.com/images/4/43/Necromancer_tango_icon_20px.png";
        private const string BaseResBladesworn = "https://wiki.guildwars2.com/images/thumb/c/c1/Bladesworn_tango_icon_200px.png/20px-Bladesworn_tango_icon_200px.png";
        private const string BaseResSpellbreaker = "https://wiki.guildwars2.com/images/e/ed/Spellbreaker_tango_icon_20px.png";
        private const string BaseResBerserker = "https://wiki.guildwars2.com/images/d/da/Berserker_tango_icon_20px.png";
        private const string BaseResWarrior = "https://wiki.guildwars2.com/images/4/43/Warrior_tango_icon_20px.png";
        private const string BaseResWillbender = "https://wiki.guildwars2.com/images/3/3a/Willbender_tango_icon_20px.png";
        private const string BaseResFirebrand = "https://wiki.guildwars2.com/images/0/02/Firebrand_tango_icon_20px.png";
        private const string BaseResDragonhunter = "https://wiki.guildwars2.com/images/c/c9/Dragonhunter_tango_icon_20px.png";
        private const string BaseResGuardian = "https://wiki.guildwars2.com/images/8/8c/Guardian_tango_icon_20px.png";
        private const string BaseResVindicator = "https://wiki.guildwars2.com/images/5/5a/Vindicator_tango_icon_20px.png";
        private const string BaseResRenegade = "https://wiki.guildwars2.com/images/7/7c/Renegade_tango_icon_20px.png";
        private const string BaseResHerald = "https://wiki.guildwars2.com/images/6/67/Herald_tango_icon_20px.png";
        private const string BaseResRevenant = "https://wiki.guildwars2.com/images/b/b5/Revenant_tango_icon_20px.png";

        // Target NPC Icons
        private const string TargetWorldVersusWorld = "https://wiki.guildwars2.com/images/d/db/PvP_Server_Browser_%28map_icon%29.png";
        private const string TargetMordremoth = "https://i.imgur.com/xcQ3AFW.png";
        private const string TargetValeGuardian = "https://i.imgur.com/MIpP5pK.png";
        private const string TargetGorseval = "https://i.imgur.com/5hmMq12.png";
        private const string TargetSabetha = "https://i.imgur.com/UqbFp9S.png";
        private const string TargetSlothasor = "https://i.imgur.com/h1xH3ER.png";
        private const string TargetBerg = "https://i.imgur.com/tLMXqL7.png";
        private const string TargetNarella = "https://i.imgur.com/FwMCoR0.png";
        private const string TargetZane = "https://i.imgur.com/tkPWMST.png";
        private const string TargetMatthias = "https://i.imgur.com/3uMMmTS.png";
        private const string TargetMcLeodTheSilent = "https://i.imgur.com/jGEmZn5.png";
        private const string TargetKeepConstruct = "https://i.imgur.com/Kq0kL07.png";
        private const string TargetXera = "https://i.imgur.com/lYwJEyV.png";
        private const string TargetCairn = "https://i.imgur.com/gQY37Tf.png";
        private const string TargetMursaatOverseer = "https://i.imgur.com/5LNiw4Y.png";
        private const string TargetSamarog = "https://i.imgur.com/MPQhKfM.png";
        private const string TargetDeimos = "https://i.imgur.com/mWfxBaO.png";
        private const string TargetDesmina = "https://i.imgur.com/jAiRplg.png";
        private const string TargetBrokenKing = "https://i.imgur.com/FNgUmvL.png";
        private const string TargetEaterOfSouls = "https://i.imgur.com/Sd6Az8M.png";
        private const string TargetEyes = "https://i.imgur.com/kAgdoa5.png";
        private const string TargetDhuum = "https://i.imgur.com/RKaDon5.png";
        private const string TargetConjuredAmalgamate = "https://i.imgur.com/C23rYTl.png";
        private const string TargetCALeftArm = "https://i.imgur.com/qrkQvEY.png";
        private const string TargetCARightArm = "https://i.imgur.com/MVwjtH7.png";
        private const string TargetKenut = "https://i.imgur.com/6yq45Cc.png";
        private const string TargetNikare = "https://i.imgur.com/TLykcrJ.png";
        private const string TargetQadim = "https://i.imgur.com/IfoHTHT.png";
        private const string TargetFreezie = "https://i.imgur.com/98uyYXk.png";
        private const string TargetAdina = "https://i.imgur.com/or3m1yb.png";
        private const string TargetSabir = "https://i.imgur.com/Q4WUXqw.png";
        private const string TargetPeerlessQadim = "https://i.imgur.com/47uePpb.png";
        private const string TargetIcebroodConstruct = "https://i.imgur.com/dpaZFa5.png";
        private const string TargetClawOfTheFallen = "https://i.imgur.com/HF85QpV.png";
        private const string TargetVoiceOfTheFallen = "https://i.imgur.com/BdTGXMU.png";
        private const string TargetVoiceAndClaw = "https://i.imgur.com/V1rJBnq.png";
        private const string TargetFraenirOfJormag = "https://i.imgur.com/MxudnKp.png";
        private const string TargetBoneskinner = "https://i.imgur.com/7HPdKDQ.png";
        private const string TargetWhisperOfJormag = "https://i.imgur.com/lu9ZLVq.png";
        private const string TargetVariniaStormsounder = "https://i.imgur.com/2o8TtiM.png";
        private const string TargetMAMA = "https://i.imgur.com/1h7HOII.png";
        private const string TargetSiax = "https://i.imgur.com/5C60cQb.png";
        private const string TargetEnsolyss = "https://i.imgur.com/GUTNuyP.png";
        private const string TargetSkorvald = "https://i.imgur.com/IOPAHRE.png";
        private const string TargetArtsariiv = "https://i.imgur.com/HwZ2g1n.png";
        private const string TargetArkk = "https://i.imgur.com/u6vv8cW.png";
        private const string TargetAiKeeperOfThePeak = "https://i.imgur.com/eCXjoAS.png";
        private const string TargetAiKeeperOfThePeak2 = "https://i.imgur.com/I8nwhAw.png";
        private const string TargetVitalGolem = "https://i.imgur.com/Te4dz9y.png";
        private const string TargetPowerGolem = "https://i.imgur.com/S6eQaSf.png";
        private const string TargetStdGolem = "https://i.imgur.com/TCSo8TI.png";
        private const string TargetMassiveGolem = "https://i.imgur.com/LRlXv1t.png";
        private const string TargetMaiTrin = "https://i.imgur.com/GjHgAtX.png";
        private const string TargetEchoOfScarletBriar = "https://i.imgur.com/O9CzW46.png";
        private const string TargetAnkka = "https://i.imgur.com/3OQwlpP.png";
        private const string TargetMinisterLi = "https://i.imgur.com/2nPBLcp.png";
        private const string TargetTheDragonVoidJormag = "https://i.imgur.com/UqHxOqi.png";
        private const string TargetTheDragonVoidKralkatorrik = "https://i.imgur.com/x9id5iH.png";
        private const string TargetTheDragonVoidMordremoth = "https://i.imgur.com/6gec61w.png";
        private const string TargetTheDragonVoidPrimordus = "https://i.imgur.com/O77QoPM.png";
        private const string TargetTheDragonVoidSooWon = "https://i.imgur.com/NHs4OFG.png";
        private const string TargetTheDragonVoidZhaitan = "https://i.imgur.com/9dpoFqR.png";
        private const string TargetSooWonOW = "https://i.imgur.com/lcZGgBC.png";
        private const string TargetPrototypeVermilion = "https://i.imgur.com/Lwz1Ypr.png";
        private const string TargetPrototypeArsenite = "https://i.imgur.com/tSD5Phl.png";
        private const string TargetPrototypeIndigo = "https://i.imgur.com/DRdLQSr.png";

        // Trash NPC Icons
        private const string TrashCanach = "https://i.imgur.com/UuxqFko.png";
        private const string TrashBraham = "https://i.imgur.com/IZwGr7N.png";
        private const string TrashCaithe = "https://i.imgur.com/gxBNudo.png";
        private const string TrashBlightedRytlock = "https://i.imgur.com/iDvXEZj.png";
        private const string TrashBlightedCanach = "https://i.imgur.com/ObZJXxd.png";
        private const string TrashBlightedBraham = "https://i.imgur.com/wcLwsIg.png";
        private const string TrashBlightedMarjory = "https://i.imgur.com/SqKNAzN.png";
        private const string TrashBlightedCaithe = "https://i.imgur.com/hruf4mI.png";
        private const string TrashBlightedForgal = "https://i.imgur.com/LIioL0V.png";
        private const string TrashBlightedSieran = "https://i.imgur.com/8EaXVPP.png";
        private const string TrashBlightedTybalt = "https://i.imgur.com/TgHJKB3.png";
        private const string TrashBlightedPaleTree = "https://i.imgur.com/l6ADzRj.png";
        private const string TrashBlightedTrahearne = "https://i.imgur.com/MIH8rLB.png";
        private const string TrashBlightedEir = "https://i.imgur.com/aAIFLgG.png";
        private const string TrashSpiritDemonSoul = "https://i.imgur.com/sHmksvO.png";
        private const string TrashSaul = "https://i.imgur.com/ck2IsoS.png";
        private const string TrashShackledPrisoner = "https://i.imgur.com/kxlMw7l.png";
        private const string TrashDemonicBond = "https://i.imgur.com/E4Jqwdn.png";
        private const string TrashGamblerClones = "https://i.imgur.com/zMsBWEx.png";
        private const string TrashChargedBloodstoneFragment = "https://i.imgur.com/PZ2VNAN.png";
        private const string TrashGamblerReal = "https://i.imgur.com/J6oMITN.png";
        private const string TrashPride = "https://i.imgur.com/ePTXx23.png";
        private const string TrashOil = "https://i.imgur.com/R26VgEr.png";
        private const string TrashTear = "https://i.imgur.com/N9seps0.png";
        private const string TrashGamblerDrunkarThief = "https://i.imgur.com/vINeVU6.png";
        private const string TrashTormentedDeadMessenger = "https://i.imgur.com/1J2BTFg.png";
        private const string TrashEnforcer = "https://i.imgur.com/elHjamF.png";
        private const string TrashEcho = "https://i.imgur.com/kcN9ECn.png";
        private const string TrashKeepConstructCoreExquisiteConjunction = "https://i.imgur.com/yI34iqw.png";
        private const string TrashKeepConstructGhosts = "https://i.imgur.com/qeYT1Bf.png";
        private const string TrashInsidiousProjection = "https://i.imgur.com/9EdItBS.png";
        private const string TrashEnergyOrb = "https://i.postimg.cc/NMNvyts0/Power-Ball.png";
        private const string TrashUnstableLeyRift = "https://i.imgur.com/YXM3igs.png";
        private const string TrashRadiantPhantasm = "https://i.imgur.com/O5VWLyY.png";
        private const string TrashCrimsonPhantasm = "https://i.imgur.com/zP7Bvb4.png";
        private const string TrashStorm = "https://i.imgur.com/9XtNPdw.png";
        private const string TrashIcePatch = "https://i.imgur.com/yxKJ5Yc.png";
        private const string TrashBanditSaboteur = "https://i.imgur.com/jUKMEbD.png";
        private const string TrashTornado = "https://i.imgur.com/e10lZMa.png";
        private const string TrashJade = "https://i.imgur.com/ivtzbSP.png";
        private const string TrashAngryChillZommoros = "https://i.imgur.com/BxbsRCI.png";
        private const string TrashAncientInvokedHydra = "https://i.imgur.com/YABLiBz.png";
        private const string TrashIcebornHydra = "https://i.imgur.com/LoYMBRU.png";
        private const string TrashIceElemental = "https://i.imgur.com/pEkBeNp.png";
        private const string TrashWyvernMatriarch = "https://i.imgur.com/kLKLSfv.png";
        private const string TrashWyvernPatriarch = "https://i.imgur.com/vjjNSpI.png";
        private const string TrashApocalypseBringer = "https://i.imgur.com/0LGKCn2.png";
        private const string TrashConjuredGreatsword = "https://i.imgur.com/vHka0QN.png";
        private const string TrashConjuredPlayerSword = "https://wiki.guildwars2.com/images/0/07/Crimson_Antique_Blade.png";
        private const string TrashConjuredShield = "https://i.imgur.com/wUiI19S.png";
        private const string TrashGreaterMagmaElemental = "https://i.imgur.com/sr146T6.png";
        private const string TrashLavaElemental = "https://i.imgur.com/mydwiYy.png";
        private const string TrashPyreGuardianKillerTornado = "https://i.imgur.com/6zNPTUw.png";
        private const string TrashPoisonMushroom = "https://i.imgur.com/AaxHiot.png";
        private const string TrashSpearAggressionRevulsion = "https://i.imgur.com/KUpmqdA.png";
        private const string TrashQadimLamp = "https://i.imgur.com/89Kjv0N.png";
        private const string TrashPyreGuardianRetal = "https://i.imgur.com/WC6LRkO.png";
        private const string TrashPyreGuardianResolution = "https://i.imgur.com/26rY9IM.png";
        private const string TrashPyreGuardianStab = "https://i.imgur.com/ISa0urR.png";
        private const string TrashPyreGuardianProtect = "https://i.imgur.com/jLW7rpV.png";
        private const string TrashReaperofFlesh = "https://i.imgur.com/Notctbt.png";
        private const string TrashKernan = "https://i.imgur.com/WABRQya.png";
        private const string TrashKnuckles = "https://i.imgur.com/m1y8nJE.png";
        private const string TrashKarde = "https://i.imgur.com/3UGyosm.png";
        private const string TrashRigom = "https://i.imgur.com/REcGMBe.png";
        private const string TrashGuldhem = "https://i.imgur.com/xa7Fefn.png";
        private const string TrashScythe = "https://i.imgur.com/INCGLIK.png";
        private const string TrashSmotheringShadow = "https://i.imgur.com/iOtx7l1.png";
        private const string TrashMazeMinotaur = "https://i.imgur.com/EMR1lQG.png";
        private const string TrashVoidSaltsprayDragon = "https://i.imgur.com/KuC1xF1.png";
        private const string TrashGenericRedEnemySkull = "https://i.imgur.com/k79t7ZA.png"; // GENERIC ICON
        private const string TrashHandOfErosionEruption = "https://i.imgur.com/reGQHhr.png";
        private const string TrashVoltaicWisp = "https://i.imgur.com/C1mvNGZ.png";
        private const string TrashParalyzingWisp = "https://i.imgur.com/YBl8Pqo.png";
        private const string TrashHostilePeerlessQadimPylon = "https://i.imgur.com/b33vAEQ.png";
        private const string TrashEntropicDistortion = "https://i.imgur.com/MIpP5pK.png";
        private const string TrashSmallJumpyTornado = "https://i.imgur.com/WBJNgp7.png";
        private const string TrashOrbSpider = "https://i.imgur.com/FB5VM9X.png";
        private const string TrashSeekers = "https://i.imgur.com/FrPoluz.png";
        private const string TrashBlueGuardian = "https://i.imgur.com/6CefnkP.png";
        private const string TrashGreenGuardian = "https://i.imgur.com/nauDVYP.png";
        private const string TrashRedGuardian = "https://i.imgur.com/73Uj4lG.png";
        private const string TrashUnderworldReaper = "https://i.imgur.com/Tq6SYVe.png";
        private const string TrashVeteranTorturedWarg = "https://i.imgur.com/NklqOp3.png";
        private const string TrashGenericFriendlyTarget = "https://i.imgur.com/0koP4xB.png"; // GENERIC ICON
        private const string TrashMine = "https://i.imgur.com/A9AxMHG.png";
        private const string TrashFleshWurm = "https://i.imgur.com/o3vX9Zc.png";
        private const string TrashHands = "https://i.imgur.com/8JRPEoo.png";
        private const string TrashTemporalAnomaly = "https://i.imgur.com/MIpP5pK.png";
        private const string TrashDOC_BLIGHT_PLINK_CHOP = "https://i.imgur.com/Te4dz9y.png";
        private const string TrashArchdiviner = "https://i.imgur.com/cuLLR43.png";
        private const string TrashEliteBrazenGladiator = "https://i.imgur.com/PrQdM0K.png";
        private const string TrashFanatic = "https://i.imgur.com/niPMlFb.png";
        private const string TrashFreeziesFrozenHeart = "https://i.imgur.com/OP8aYhI.png";
        private const string TrashRiverOfSouls = "https://i.imgur.com/4pXEnaX.png";
        private const string TrashWargBloodhound = "https://i.imgur.com/AATY8BJ.png";
        private const string TrashCrimsonMcLeod = "https://i.imgur.com/dLNMI85.png";
        private const string TrashRadiantMcLeod = "https://i.imgur.com/ZlPTU4a.png";
        private const string TrashDhuumDesmina = "https://i.imgur.com/jAiRplg.png";
        private const string TrashGlenna = "https://i.imgur.com/qOPm38P.png";
        private const string TrashVoidStormseer = "https://i.imgur.com/ZullvP1.png";
        private const string TrashVoidWarforged = "https://i.imgur.com/gea0hIt.png";
        private const string TrashVoidRotswarmer = "https://i.imgur.com/Lyi1n9c.png";
        private const string TrashVoidMelter = "https://i.imgur.com/k6jyCMc.png";
        private const string TrashVoidGiant = "https://i.imgur.com/PnaeYp4.png";
        private const string TrashZhaitansReach = "https://i.imgur.com/h1sNdhU.png";
        private const string TrashVoidAbomination = "https://i.imgur.com/h4ONU1u.png";
        private const string TrashVoidColdsteel = "https://i.imgur.com/iEofFua.png";
        private const string TrashVoidTangler = "https://i.imgur.com/qqUgKGE.png";
        private const string TrashVoidObliterator = "https://i.imgur.com/5DzJct1.png";
        private const string TrashVoidGoliath = "https://i.imgur.com/Yz62GKB.png";
        private const string TrashVoidBrandbomber = "https://i.imgur.com/s8e1QhP.png";
        private const string TrashVoidSkullpiercer = "https://i.imgur.com/7HLTnsp.png";
        private const string TrashVoidTimeCaster = "https://i.imgur.com/AKWe7od.png";
        private const string TrashVoidThornheart = "https://i.imgur.com/rts8zEg.png";
        private const string TrashVoidBrandfang = "https://i.imgur.com/UUuIS9u.png";
        private const string TrashVoidBrandbeast = "https://i.imgur.com/bnuIjnn.png";
        private const string TrashVoidBrandscale = "https://i.imgur.com/RlcKaWe.png";
        private const string TrashVoidFrostwing = "https://i.imgur.com/KbTHpBb.png";
        private const string TrashCastleFountain = "https://i.imgur.com/xV0OPWL.png";
        private const string TrashHauntingStatue = "https://i.imgur.com/7IQDyuK.png";
        private const string TrashRGBKnight = "https://i.imgur.com/lpBm4d6.png";
        private const string TrashCloneArtsariiv = "https://i.imgur.com/8I6ectk.png";
        private const string TrashMaiTrinStrikeDuringEcho = "https://i.imgur.com/GjHgAtX.png";
        private const string TrashSooWonTail = "https://i.imgur.com/O8VEP57.png";
        private const string TrashTheEnforcer = "https://i.imgur.com/GNQCYda.png";
        private const string TrashTheMechRider = "https://i.imgur.com/JSsBc6a.png";
        private const string TrashTheMindblade = "https://i.imgur.com/KyMgGQD.png";
        private const string TrashTheRitualist = "https://i.imgur.com/gG5p3Hz.png";
        private const string TrashTheSniper = "https://i.imgur.com/RWIjUoe.png";
        private const string TrashVoidAmalgamate = "https://i.imgur.com/BuKbosz.png";

        // Minion NPC Icons
        private const string MinionRuneJaggedHorror = "https://i.imgur.com/opMTn10.png";
        private const string MinionRuneMarkIGolem = "https://i.imgur.com/0ePg7eN.png";
        private const string MinionMesmerClone = "https://i.imgur.com/5Hknsa6.png";
        private const string MinionIllusionarySwordsman = "https://i.imgur.com/ReUwrAL.png";
        private const string MinionIllusionaryBerserker = "https://i.imgur.com/VNcYhXZ.png";
        private const string MinionIllusionaryDisenchanter = "https://i.imgur.com/Jbg96sq.png";
        private const string MinionIllusionaryRogue = "https://i.imgur.com/3v4pj2C.png";
        private const string MinionIllusionaryDefender = "https://i.imgur.com/jXp8Q9M.png";
        private const string MinionIllusionaryMage = "https://i.imgur.com/xIGA5Xj.png";
        private const string MinionIllusionaryDuelist = "https://i.imgur.com/ZY54uOt.png";
        private const string MinionIllusionaryWarden = "https://i.imgur.com/dId5lC2.png";
        private const string MinionIllusionaryWarlock = "https://i.imgur.com/ZRCcbBM.png";
        private const string MinionIllusionaryAvenger = "https://i.imgur.com/SmEAtBo.png";
        private const string MinionJadeMech = "https://i.imgur.com/54evTaq.png";
        private const string MinionEraBreakrazor = "https://i.imgur.com/2X3G3Fl.png";
        private const string MinionKusDarkrazor = "https://i.imgur.com/rJq4Ngh.png";
        private const string MinionViskIcerazor = "https://i.imgur.com/SlTx8R5.png";
        private const string MinionJasRazorclaw = "https://i.imgur.com/SkSsLmw.png";
        private const string MinionOfelaSoulcleave = "https://i.imgur.com/xFsl0gj.png";
        private const string MinionVentariTablet = "https://i.imgur.com/nRoYMep.png";
        private const string MinionFrostSpirit = "https://i.imgur.com/dfbRWGh.png";
        private const string MinionSunSpirit = "https://i.imgur.com/HtCusPF.png";
        private const string MinionSpiritOfNatureRenewal = "https://i.imgur.com/sGMfD5j.png";
        private const string MinionStoneSpirit = "https://i.imgur.com/4r6Ytj5.png";
        private const string MinionStormSpirit = "https://i.imgur.com/jXmencD.png";
        private const string MinionJuvenileAlpineWolf = "https://i.imgur.com/6NJ4PJx.png";
        private const string MinionJuvenileArctodus = "https://i.imgur.com/of68C0V.png";
        private const string MinionJuvenileArmorFish = "https://i.imgur.com/s6jE8ex.png";
        private const string MinionJuvenileBlackBear = "https://i.imgur.com/VAza7ac.png";
        private const string MinionJuvenileBlackMoa = "https://i.imgur.com/l47XZUw.png";
        private const string MinionJuvenileBlackWidowSpider = "https://i.imgur.com/dNRN5Cd.png";
        private const string MinionJuvenileBlueRainbowJellyfish = "https://i.imgur.com/kS5xGdi.png";
        private const string MinionJuvenileBlueMoa = "https://i.imgur.com/8lC1l7N.png";
        private const string MinionJuvenileBoar = "https://i.imgur.com/l9ZDJoG.png";
        private const string MinionJuvenileBristleback = "https://i.imgur.com/rLFL4JL.png";
        private const string MinionJuvenileBrownBear = "https://i.imgur.com/tTR3z9V.png";
        private const string MinionJuvenileCheetah = "https://i.imgur.com/IosaqHc.png";
        private const string MinionJuvenileEagle = "https://i.imgur.com/WuOl5qh.png";
        private const string MinionJuvenileEletricWywern = "https://i.imgur.com/RsSNDV3.png";
        private const string MinionJuvenileFangedIboga = "https://i.imgur.com/cRE9fwE.png";
        private const string MinionJuvenileFernHound = "https://i.imgur.com/j1c43bj.png";
        private const string MinionJuvenileFireWywern = "https://i.imgur.com/WjODNiP.png";
        private const string MinionJuvenileForestSpider = "https://i.imgur.com/Xu5kRnv.png";
        private const string MinionJuvenileIceDrake = "https://i.imgur.com/SlbkLrD.png";
        private const string MinionJuvenileJacaranda = "https://i.imgur.com/IrmdDqo.png";
        private const string MinionJuvenileJungleSpider = "https://i.imgur.com/4zNZcn8.png";
        private const string MinionJuvenileJungleStalker = "https://i.imgur.com/jM51zQ0.png";
        private const string MinionJuvenileKrytanDrakehound = "https://i.imgur.com/KZZ0YPw.png";
        private const string MinionJuvenileLashtailDevourer = "https://i.imgur.com/CnRTFH8.png";
        private const string MinionJuvenileLynx = "https://i.imgur.com/fCjd2Qz.png";
        private const string MinionJuvenileMarshDrake = "https://i.imgur.com/5EuKe2F.png";
        private const string MinionJuvenileOwl = "https://i.imgur.com/dh3thfS.png";
        private const string MinionJuvenilePig = "https://i.imgur.com/kjj0810.png";
        private const string MinionJuvenilePinkMoa = "https://i.imgur.com/AdzQreO.png";
        private const string MinionJuvenileRedJellyfish = "https://i.imgur.com/BlQij3o.png";
        private const string MinionJuvenileRedMoa = "https://i.imgur.com/N97LXIO.png";
        private const string MinionJuvenileRiverDrake = "https://i.imgur.com/K56jP8H.png";
        private const string MinionJuvenileRockGazelle = "https://i.imgur.com/XV1ySBt.png";
        private const string MinionJuvenileSalamanderDraker = "https://i.imgur.com/2EK2OBE.png";
        private const string MinionJuvenileSandLion = "https://i.imgur.com/XDkpvp9.png";
        private const string MinionJuvenileWhiteTiger = "https://i.imgur.com/B6wtfhQ.png";
        private const string MinionJuvenileShark = "https://i.imgur.com/vZ9jIE9.png";
        private const string MinionJuvenileSmokescale = "https://i.imgur.com/30k6BmC.png";
        private const string MinionJuvenileTiger = "https://i.imgur.com/vALPpMJ.png";
        private const string MinionJuvenileWarthog = "https://i.imgur.com/MPPsWBH.png";
        private const string MinionJuvenileWhiptailDevourer = "https://i.imgur.com/hqWNZkD.png";
        private const string MinionJuvenileWolf = "https://i.imgur.com/GQLiFky.png";
        private const string MinionBloodFiend = "https://i.imgur.com/PrOpULe.png";
        private const string MinionBoneFiend = "https://i.imgur.com/BEntBIt.png";
        private const string MinionFleshGolem = "https://i.imgur.com/JkYUNug.png";
        private const string MinionShadowFiend = "https://i.imgur.com/Undu5EU.png";
        private const string MinionFleshWurm = "https://i.imgur.com/Bc1VfLm.png";
        private const string MinionUnstableHorror = "https://i.imgur.com/zHPC8BX.png";
        private const string MinionShamblingHorror = "https://i.imgur.com/eeE34so.png";
        private const string MinionThiefDaredevilDeadeye = "https://i.imgur.com/6YkM5zY.png";
        private const string MinionBowOfTruth = "https://i.imgur.com/i9uCT6p.png";
        private const string MinionHammerOfWisdom = "https://i.imgur.com/XXrlAma.png";
        private const string MinionShieldOfTheAvenger = "https://i.imgur.com/86a9LQ3.png";
        private const string MinionSwordOfJustice = "https://i.imgur.com/BKJz3br.png";
        private const string MinionLesserAirElemental = "https://i.imgur.com/T8Qb5j7.png";
        private const string MinionLesserEarthElemental = "https://i.imgur.com/E4M9YXp.png";
        private const string MinionLesserFireElemental = "https://i.imgur.com/X2QIo3j.png";
        private const string MinionLesserIceElemental = "https://i.imgur.com/ldzBrLt.png";
        private const string MinionAirElemental = "https://i.imgur.com/2cjYTg3.png";
        private const string MinionEarthElemental = "https://i.imgur.com/OrueMCk.png";
        private const string MinionFireElemental = "https://i.imgur.com/7Qhev66.png";
        private const string MinionIceElemental = "https://i.imgur.com/BTf2r0D.png";

        /// <summary>
        /// Dictionary matching a <see cref="Spec"/> to their high resolution profession icon.
        /// </summary>
        internal static IReadOnlyDictionary<Spec, string> HighResProfIcons { get; private set; } = new Dictionary<Spec, string>()
        {
            { Spec.Untamed, HighResUntamed },
            { Spec.Soulbeast, HighResSoulbeast },
            { Spec.Druid, HighResDruid },
            { Spec.Ranger, HighResRanger },
            { Spec.Mechanist, HighResMechanist },
            { Spec.Holosmith, HighResHolosmith },
            { Spec.Scrapper, HighResScrapper },
            { Spec.Engineer, HighResEngineer },
            { Spec.Specter, HighResSpecter },
            { Spec.Deadeye, HighResDeadeye },
            { Spec.Daredevil, HighResDaredevil },
            { Spec.Thief, HighResThief },
            { Spec.Catalyst, HighResCatalyst },
            { Spec.Weaver, HighResWeaver },
            { Spec.Tempest, HighResTempest },
            { Spec.Elementalist, HighResElementalist },
            { Spec.Virtuoso, HighResVirtuoso },
            { Spec.Mirage, HighResMirage },
            { Spec.Chronomancer, HighResChronomancer },
            { Spec.Mesmer, HighResMesmer },
            { Spec.Harbinger, HighResHarbinger },
            { Spec.Scourge, HighResScourge },
            { Spec.Reaper, HighResReaper },
            { Spec.Necromancer, HighResNecromancer },
            { Spec.Bladesworn, HighResBladesworn },
            { Spec.Spellbreaker, HighResSpellbreaker },
            { Spec.Berserker, HighResBerserker },
            { Spec.Warrior, HighResWarrior },
            { Spec.Willbender, HighResWillbender },
            { Spec.Firebrand, HighResFirebrand },
            { Spec.Dragonhunter, HighResDragonhunter },
            { Spec.Guardian, HighResGuardian },
            { Spec.Vindicator, HighResVindicator },
            { Spec.Renegade, HighResRenegade },
            { Spec.Herald, HighResHerald },
            { Spec.Revenant, HighResRevenant },
        };

        /// <summary>
        /// Dictionary matching a <see cref="Spec"/> to their base resolution profession icon.
        /// </summary>
        internal static IReadOnlyDictionary<Spec, string> BaseResProfIcons { get; private set; } = new Dictionary<Spec, string>()
        {
            { Spec.Untamed, BaseResUntamed },
            { Spec.Soulbeast, BaseResSoulbeast },
            { Spec.Druid, BaseResDruid },
            { Spec.Ranger, BaseResRanger },
            { Spec.Mechanist, BaseResMechanist },
            { Spec.Holosmith, BaseResHolosmith },
            { Spec.Scrapper, BaseResScrapper },
            { Spec.Engineer, BaseResEngineer },
            { Spec.Specter, BaseResSpecter },
            { Spec.Deadeye, BaseResDeadeye },
            { Spec.Daredevil, BaseResDaredevil },
            { Spec.Thief, BaseResThief },
            { Spec.Catalyst, BaseResCatalyst },
            { Spec.Weaver, BaseResWeaver },
            { Spec.Tempest, BaseResTempest },
            { Spec.Elementalist, BaseResElementalist },
            { Spec.Virtuoso, BaseResVirtuoso },
            { Spec.Mirage, BaseResMirage },
            { Spec.Chronomancer, BaseResChronomancer },
            { Spec.Mesmer, BaseResMesmer },
            { Spec.Harbinger, BaseResHarbinger },
            { Spec.Scourge, BaseResScourge },
            { Spec.Reaper, BaseResReaper },
            { Spec.Necromancer, BaseResNecromancer },
            { Spec.Bladesworn, BaseResBladesworn },
            { Spec.Spellbreaker, BaseResSpellbreaker },
            { Spec.Berserker, BaseResBerserker },
            { Spec.Warrior, BaseResWarrior },
            { Spec.Willbender, BaseResWillbender },
            { Spec.Firebrand, BaseResFirebrand },
            { Spec.Dragonhunter, BaseResDragonhunter },
            { Spec.Guardian, BaseResGuardian },
            { Spec.Vindicator, BaseResVindicator },
            { Spec.Renegade, BaseResRenegade },
            { Spec.Herald, BaseResHerald },
            { Spec.Revenant, BaseResRevenant },
        };

        /// <summary>
        /// Dictionary matching a <see cref="ArcDPSEnums.TargetID"/> to their icon.
        /// </summary>
        internal static IReadOnlyDictionary<ArcDPSEnums.TargetID, string> TargetNPCIcons { get; private set; } = new Dictionary<ArcDPSEnums.TargetID, string>()
        {
            { ArcDPSEnums.TargetID.WorldVersusWorld, TargetWorldVersusWorld },
            { ArcDPSEnums.TargetID.Mordremoth, TargetMordremoth },
            { ArcDPSEnums.TargetID.ValeGuardian, TargetValeGuardian },
            { ArcDPSEnums.TargetID.Gorseval, TargetGorseval },
            { ArcDPSEnums.TargetID.Sabetha, TargetSabetha },
            { ArcDPSEnums.TargetID.Slothasor, TargetSlothasor },
            { ArcDPSEnums.TargetID.Berg, TargetBerg },
            { ArcDPSEnums.TargetID.Narella, TargetNarella },
            { ArcDPSEnums.TargetID.Zane, TargetZane},
            { ArcDPSEnums.TargetID.Matthias, TargetMatthias },
            { ArcDPSEnums.TargetID.McLeodTheSilent, TargetMcLeodTheSilent },
            { ArcDPSEnums.TargetID.KeepConstruct, TargetKeepConstruct },
            { ArcDPSEnums.TargetID.Xera, TargetXera },
            { ArcDPSEnums.TargetID.Cairn, TargetCairn },
            { ArcDPSEnums.TargetID.MursaatOverseer, TargetMursaatOverseer },
            { ArcDPSEnums.TargetID.Samarog, TargetSamarog },
            { ArcDPSEnums.TargetID.Deimos, TargetDeimos },
            { ArcDPSEnums.TargetID.SoullessHorror, TargetDesmina },
            { ArcDPSEnums.TargetID.Desmina, TargetDesmina },
            { ArcDPSEnums.TargetID.BrokenKing, TargetBrokenKing },
            { ArcDPSEnums.TargetID.EaterOfSouls, TargetEaterOfSouls },
            { ArcDPSEnums.TargetID.EyeOfFate, TargetEyes },
            { ArcDPSEnums.TargetID.EyeOfJudgement, TargetEyes },
            { ArcDPSEnums.TargetID.Dhuum, TargetDhuum },
            { ArcDPSEnums.TargetID.ConjuredAmalgamate, TargetConjuredAmalgamate },
            { ArcDPSEnums.TargetID.CALeftArm, TargetCALeftArm },
            { ArcDPSEnums.TargetID.CARightArm, TargetCARightArm },
            { ArcDPSEnums.TargetID.Kenut, TargetKenut },
            { ArcDPSEnums.TargetID.Nikare, TargetNikare },
            { ArcDPSEnums.TargetID.Qadim, TargetQadim },
            { ArcDPSEnums.TargetID.Freezie, TargetFreezie },
            { ArcDPSEnums.TargetID.Adina, TargetAdina },
            { ArcDPSEnums.TargetID.Sabir, TargetSabir },
            { ArcDPSEnums.TargetID.PeerlessQadim, TargetPeerlessQadim },
            { ArcDPSEnums.TargetID.IcebroodConstruct, TargetIcebroodConstruct },
            { ArcDPSEnums.TargetID.IcebroodConstructFraenir, TargetIcebroodConstruct },
            { ArcDPSEnums.TargetID.ClawOfTheFallen, TargetClawOfTheFallen },
            { ArcDPSEnums.TargetID.VoiceOfTheFallen, TargetVoiceOfTheFallen },
            { ArcDPSEnums.TargetID.VoiceAndClaw, TargetVoiceAndClaw },
            { ArcDPSEnums.TargetID.FraenirOfJormag, TargetFraenirOfJormag },
            { ArcDPSEnums.TargetID.Boneskinner, TargetBoneskinner },
            { ArcDPSEnums.TargetID.WhisperOfJormag, TargetWhisperOfJormag },
            { ArcDPSEnums.TargetID.VariniaStormsounder, TargetVariniaStormsounder },
            { ArcDPSEnums.TargetID.MAMA, TargetMAMA },
            { ArcDPSEnums.TargetID.Siax, TargetSiax},
            { ArcDPSEnums.TargetID.Ensolyss, TargetEnsolyss },
            { ArcDPSEnums.TargetID.Skorvald, TargetSkorvald },
            { ArcDPSEnums.TargetID.Artsariiv, TargetArtsariiv },
            { ArcDPSEnums.TargetID.Arkk, TargetArkk },
            { ArcDPSEnums.TargetID.AiKeeperOfThePeak, TargetAiKeeperOfThePeak },
            { ArcDPSEnums.TargetID.AiKeeperOfThePeak2, TargetAiKeeperOfThePeak2 },
            { ArcDPSEnums.TargetID.LGolem, TargetVitalGolem },
            { ArcDPSEnums.TargetID.VitalGolem, TargetVitalGolem },
            { ArcDPSEnums.TargetID.PowerGolem, TargetPowerGolem },
            { ArcDPSEnums.TargetID.ConditionGolem, TargetPowerGolem },
            { ArcDPSEnums.TargetID.MedGolem, TargetPowerGolem },
            { ArcDPSEnums.TargetID.AvgGolem, TargetPowerGolem },
            { ArcDPSEnums.TargetID.StdGolem, TargetStdGolem },
            { ArcDPSEnums.TargetID.MassiveGolem10M, TargetMassiveGolem },
            { ArcDPSEnums.TargetID.MassiveGolem4M, TargetMassiveGolem },
            { ArcDPSEnums.TargetID.MassiveGolem1M, TargetMassiveGolem },
            { ArcDPSEnums.TargetID.MaiTrinFract, TargetMaiTrin },
            { ArcDPSEnums.TargetID.MaiTrinStrike, TargetMaiTrin },
            { ArcDPSEnums.TargetID.EchoOfScarletBriarNM, TargetEchoOfScarletBriar },
            { ArcDPSEnums.TargetID.EchoOfScarletBriarCM, TargetEchoOfScarletBriar },
            { ArcDPSEnums.TargetID.Ankka, TargetAnkka },
            { ArcDPSEnums.TargetID.MinisterLi, TargetMinisterLi },
            { ArcDPSEnums.TargetID.MinisterLiCM, TargetMinisterLi },
            { ArcDPSEnums.TargetID.TheDragonVoidJormag, TargetTheDragonVoidJormag },
            { ArcDPSEnums.TargetID.TheDragonVoidKralkatorrik, TargetTheDragonVoidKralkatorrik },
            { ArcDPSEnums.TargetID.TheDragonVoidMordremoth, TargetTheDragonVoidMordremoth },
            { ArcDPSEnums.TargetID.TheDragonVoidPrimordus, TargetTheDragonVoidPrimordus },
            { ArcDPSEnums.TargetID.TheDragonVoidSooWon, TargetTheDragonVoidSooWon },
            { ArcDPSEnums.TargetID.TheDragonVoidZhaitan, TargetTheDragonVoidZhaitan },
            { ArcDPSEnums.TargetID.SooWonOW, TargetSooWonOW },
            { ArcDPSEnums.TargetID.PrototypeVermilion, TargetPrototypeVermilion },
            { ArcDPSEnums.TargetID.PrototypeVermilionCM, TargetPrototypeVermilion },
            { ArcDPSEnums.TargetID.PrototypeArsenite, TargetPrototypeArsenite },
            { ArcDPSEnums.TargetID.PrototypeArseniteCM, TargetPrototypeArsenite },
            { ArcDPSEnums.TargetID.PrototypeIndigo, TargetPrototypeIndigo },
            { ArcDPSEnums.TargetID.PrototypeIndigoCM, TargetPrototypeIndigo },
        };

        /// <summary>
        /// Dictionary matching a <see cref="ArcDPSEnums.TrashID"/> to their icon.
        /// </summary>
        internal static IReadOnlyDictionary<ArcDPSEnums.TrashID, string> TrashNPCIcons { get; private set; } = new Dictionary<ArcDPSEnums.TrashID, string>()
        {
            { ArcDPSEnums.TrashID.Canach, TrashCanach },
            { ArcDPSEnums.TrashID.Braham, TrashBraham },
            { ArcDPSEnums.TrashID.Caithe, TrashCaithe },
            { ArcDPSEnums.TrashID.BlightedRytlock, TrashBlightedRytlock },
            //{ ArcDPSEnums.TrashID.BlightedCanach, TrashBlightedCanach },
            { ArcDPSEnums.TrashID.BlightedBraham, TrashBlightedBraham },
            { ArcDPSEnums.TrashID.BlightedMarjory, TrashBlightedMarjory },
            { ArcDPSEnums.TrashID.BlightedCaithe, TrashBlightedCaithe },
            { ArcDPSEnums.TrashID.BlightedForgal, TrashBlightedForgal },
            { ArcDPSEnums.TrashID.BlightedSieran, TrashBlightedSieran },
            //{ ArcDPSEnums.TrashID.BlightedTybalt, TrashBlightedTybalt },
            //{ ArcDPSEnums.TrashID.BlightedPaleTree, TrashBlightedPaleTree },
            //{ ArcDPSEnums.TrashID.BlightedTrahearne, TrashBlightedTrahearne },
            //{ ArcDPSEnums.TrashID.BlightedEir, TrashBlightedEir },
            { ArcDPSEnums.TrashID.Spirit, TrashSpiritDemonSoul },
            { ArcDPSEnums.TrashID.Spirit2, TrashSpiritDemonSoul },
            { ArcDPSEnums.TrashID.ChargedSoul, TrashSpiritDemonSoul },
            { ArcDPSEnums.TrashID.HollowedBomber, TrashSpiritDemonSoul },
            { ArcDPSEnums.TrashID.GuiltDemon, TrashSpiritDemonSoul },
            { ArcDPSEnums.TrashID.DoubtDemon, TrashSpiritDemonSoul },
            { ArcDPSEnums.TrashID.Saul, TrashSaul },
            { ArcDPSEnums.TrashID.ShackledPrisoner, TrashShackledPrisoner },
            { ArcDPSEnums.TrashID.DemonicBond, TrashDemonicBond },
            { ArcDPSEnums.TrashID.GamblerClones, TrashGamblerClones },
            { ArcDPSEnums.TrashID.BloodstoneFragment, TrashChargedBloodstoneFragment },
            { ArcDPSEnums.TrashID.ChargedBloodstone, TrashChargedBloodstoneFragment },
            { ArcDPSEnums.TrashID.BloodstoneShardMainFight, TrashGamblerReal },
            { ArcDPSEnums.TrashID.BloodstoneShardRift, TrashGamblerReal },
            { ArcDPSEnums.TrashID.BloodstoneShardButton, TrashGamblerReal },
            { ArcDPSEnums.TrashID.GamblerReal, TrashGamblerReal },
            { ArcDPSEnums.TrashID.Pride, TrashPride },
            { ArcDPSEnums.TrashID.OilSlick, TrashOil },
            { ArcDPSEnums.TrashID.Oil, TrashOil },
            { ArcDPSEnums.TrashID.Tear, TrashTear },
            { ArcDPSEnums.TrashID.Gambler, TrashGamblerDrunkarThief },
            { ArcDPSEnums.TrashID.Drunkard, TrashGamblerDrunkarThief },
            { ArcDPSEnums.TrashID.Thief, TrashGamblerDrunkarThief },
            { ArcDPSEnums.TrashID.TormentedDead, TrashTormentedDeadMessenger },
            { ArcDPSEnums.TrashID.Messenger, TrashTormentedDeadMessenger },
            { ArcDPSEnums.TrashID.Enforcer, TrashEnforcer },
            { ArcDPSEnums.TrashID.Echo, TrashEcho },
            { ArcDPSEnums.TrashID.KeepConstructCore, TrashKeepConstructCoreExquisiteConjunction },
            { ArcDPSEnums.TrashID.ExquisiteConjunction, TrashKeepConstructCoreExquisiteConjunction },
            { ArcDPSEnums.TrashID.Jessica, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Olson, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Engul, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Faerla, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Caulle, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Henley, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Galletta, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.Ianim, TrashKeepConstructGhosts },
            { ArcDPSEnums.TrashID.InsidiousProjection, TrashInsidiousProjection },
            { ArcDPSEnums.TrashID.EnergyOrb, TrashEnergyOrb },
            { ArcDPSEnums.TrashID.UnstableLeyRift, TrashUnstableLeyRift },
            { ArcDPSEnums.TrashID.RadiantPhantasm, TrashRadiantPhantasm },
            { ArcDPSEnums.TrashID.CrimsonPhantasm, TrashCrimsonPhantasm },
            { ArcDPSEnums.TrashID.Storm, TrashStorm },
            { ArcDPSEnums.TrashID.IcePatch, TrashIcePatch },
            { ArcDPSEnums.TrashID.BanditSaboteur, TrashBanditSaboteur },
            { ArcDPSEnums.TrashID.NarellaTornado, TrashTornado },
            { ArcDPSEnums.TrashID.Tornado, TrashTornado },
            { ArcDPSEnums.TrashID.Jade, TrashJade },
            { ArcDPSEnums.TrashID.AngryZommoros, TrashAngryChillZommoros },
            { ArcDPSEnums.TrashID.ChillZommoros, TrashAngryChillZommoros },
            { ArcDPSEnums.TrashID.AncientInvokedHydra, TrashAncientInvokedHydra },
            { ArcDPSEnums.TrashID.IcebornHydra, TrashIcebornHydra },
            { ArcDPSEnums.TrashID.IceElemental, TrashIceElemental },
            { ArcDPSEnums.TrashID.WyvernMatriarch, TrashWyvernMatriarch },
            { ArcDPSEnums.TrashID.WyvernPatriarch, TrashWyvernPatriarch },
            { ArcDPSEnums.TrashID.ApocalypseBringer, TrashApocalypseBringer },
            { ArcDPSEnums.TrashID.ConjuredGreatsword, TrashConjuredGreatsword },
            { ArcDPSEnums.TrashID.ConjuredPlayerSword, TrashConjuredPlayerSword },
            { ArcDPSEnums.TrashID.ConjuredShield, TrashConjuredShield },
            { ArcDPSEnums.TrashID.GreaterMagmaElemental1, TrashGreaterMagmaElemental },
            { ArcDPSEnums.TrashID.GreaterMagmaElemental2, TrashGreaterMagmaElemental },
            { ArcDPSEnums.TrashID.LavaElemental1, TrashLavaElemental },
            { ArcDPSEnums.TrashID.LavaElemental2, TrashLavaElemental },
            { ArcDPSEnums.TrashID.PyreGuardian, TrashPyreGuardianKillerTornado },
            { ArcDPSEnums.TrashID.SmallKillerTornado, TrashPyreGuardianKillerTornado},
            { ArcDPSEnums.TrashID.BigKillerTornado, TrashPyreGuardianKillerTornado },
            { ArcDPSEnums.TrashID.PoisonMushroom, TrashPoisonMushroom },
            { ArcDPSEnums.TrashID.SpearAggressionRevulsion, TrashSpearAggressionRevulsion },
            { ArcDPSEnums.TrashID.QadimLamp, TrashQadimLamp },
            { ArcDPSEnums.TrashID.PyreGuardianRetal, TrashPyreGuardianRetal },
            { ArcDPSEnums.TrashID.PyreGuardianResolution, TrashPyreGuardianResolution },
            { ArcDPSEnums.TrashID.PyreGuardianStab, TrashPyreGuardianStab },
            { ArcDPSEnums.TrashID.PyreGuardianProtect, TrashPyreGuardianProtect },
            { ArcDPSEnums.TrashID.ReaperofFlesh, TrashReaperofFlesh },
            { ArcDPSEnums.TrashID.Kernan, TrashKernan },
            { ArcDPSEnums.TrashID.Knuckles, TrashKnuckles },
            { ArcDPSEnums.TrashID.Karde, TrashKarde },
            { ArcDPSEnums.TrashID.Rigom, TrashRigom },
            { ArcDPSEnums.TrashID.Guldhem, TrashGuldhem },
            { ArcDPSEnums.TrashID.Scythe, TrashScythe },
            { ArcDPSEnums.TrashID.SmotheringShadow, TrashSmotheringShadow },
            { ArcDPSEnums.TrashID.MazeMinotaur, TrashMazeMinotaur },
            { ArcDPSEnums.TrashID.VoidSaltsprayDragon, TrashVoidSaltsprayDragon },
            { ArcDPSEnums.TrashID.BanditBombardier, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.EchoOfTheUnclean, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SurgingSoul, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.Enervator, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.WhisperEcho, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.CharrTank, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.PropagandaBallon, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.FearDemon, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SorrowDemon1, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SorrowDemon2, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SorrowDemon3, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SorrowDemon4, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SorrowDemon5, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.ScarletPhantomHP, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.ScarletPhantomHP2, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.ScarletPhantomBreakbar, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.AnkkaHallucination1, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.AnkkaHallucination2, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.AnkkaHallucination3, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.VoidBrandstalker, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SpiritOfDestruction, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.SpiritOfPain, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.DragonEnergyOrb, TrashGenericRedEnemySkull },
            { ArcDPSEnums.TrashID.HandOfErosion, TrashHandOfErosionEruption },
            { ArcDPSEnums.TrashID.HandOfEruption, TrashHandOfErosionEruption },
            { ArcDPSEnums.TrashID.VoltaicWisp, TrashVoltaicWisp },
            { ArcDPSEnums.TrashID.ParalyzingWisp, TrashParalyzingWisp },
            { ArcDPSEnums.TrashID.HostilePeerlessQadimPylon, TrashHostilePeerlessQadimPylon },
            { ArcDPSEnums.TrashID.EntropicDistortion, TrashEntropicDistortion },
            { ArcDPSEnums.TrashID.SmallJumpyTornado, TrashSmallJumpyTornado },
            { ArcDPSEnums.TrashID.OrbSpider, TrashOrbSpider },
            { ArcDPSEnums.TrashID.Seekers, TrashSeekers },
            { ArcDPSEnums.TrashID.BlueGuardian, TrashBlueGuardian },
            { ArcDPSEnums.TrashID.GreenGuardian, TrashGreenGuardian },
            { ArcDPSEnums.TrashID.RedGuardian, TrashRedGuardian },
            { ArcDPSEnums.TrashID.UnderworldReaper, TrashUnderworldReaper },
            { ArcDPSEnums.TrashID.VeteranTorturedWarg, TrashVeteranTorturedWarg },
            { ArcDPSEnums.TrashID.GreenSpirit1, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.GreenSpirit2, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.BanditSapper, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.ProjectionArkk, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.PrioryExplorer, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.PrioryScholar, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.VigilRecruit, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.VigilTactician, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.Prisoner1, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.Prisoner2, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.FriendlyPeerlessQadimPylon, TrashGenericFriendlyTarget },
            { ArcDPSEnums.TrashID.Mine, TrashMine },
            { ArcDPSEnums.TrashID.FleshWurm, TrashFleshWurm },
            { ArcDPSEnums.TrashID.Hands, TrashHands },
            { ArcDPSEnums.TrashID.TemporalAnomaly, TrashTemporalAnomaly },
            { ArcDPSEnums.TrashID.TemporalAnomaly2, TrashTemporalAnomaly },
            { ArcDPSEnums.TrashID.DOC, TrashDOC_BLIGHT_PLINK_CHOP },
            { ArcDPSEnums.TrashID.BLIGHT, TrashDOC_BLIGHT_PLINK_CHOP },
            { ArcDPSEnums.TrashID.PLINK, TrashDOC_BLIGHT_PLINK_CHOP },
            { ArcDPSEnums.TrashID.CHOP, TrashDOC_BLIGHT_PLINK_CHOP },
            { ArcDPSEnums.TrashID.Archdiviner, TrashArchdiviner },
            { ArcDPSEnums.TrashID.EliteBrazenGladiator, TrashEliteBrazenGladiator },
            { ArcDPSEnums.TrashID.Fanatic, TrashFanatic },
            { ArcDPSEnums.TrashID.FreeziesFrozenHeart, TrashFreeziesFrozenHeart },
            { ArcDPSEnums.TrashID.RiverOfSouls, TrashRiverOfSouls },
            { ArcDPSEnums.TrashID.WargBloodhound, TrashWargBloodhound },
            { ArcDPSEnums.TrashID.CrimsonMcLeod, TrashCrimsonMcLeod },
            { ArcDPSEnums.TrashID.RadiantMcLeod, TrashRadiantMcLeod },
            { ArcDPSEnums.TrashID.DhuumDesmina, TrashDhuumDesmina },
            { ArcDPSEnums.TrashID.Glenna, TrashGlenna },
            { ArcDPSEnums.TrashID.VoidStormseer, TrashVoidStormseer },
            { ArcDPSEnums.TrashID.VoidStormseer2, TrashVoidStormseer },
            { ArcDPSEnums.TrashID.VoidStormseer3, TrashVoidStormseer },
            { ArcDPSEnums.TrashID.VoidWarforged1, TrashVoidWarforged },
            { ArcDPSEnums.TrashID.VoidWarforged2, TrashVoidWarforged },
            { ArcDPSEnums.TrashID.VoidRotswarmer, TrashVoidRotswarmer },
            { ArcDPSEnums.TrashID.VoidMelter, TrashVoidMelter },
            { ArcDPSEnums.TrashID.VoidMelter1, TrashVoidMelter },
            { ArcDPSEnums.TrashID.VoidMelter2, TrashVoidMelter },
            { ArcDPSEnums.TrashID.VoidGiant, TrashVoidGiant },
            { ArcDPSEnums.TrashID.VoidGiant2, TrashVoidGiant },
            { ArcDPSEnums.TrashID.ZhaitansReach, TrashZhaitansReach },
            { ArcDPSEnums.TrashID.VoidAbomination, TrashVoidAbomination },
            { ArcDPSEnums.TrashID.VoidAbomination2, TrashVoidAbomination },
            { ArcDPSEnums.TrashID.VoidColdsteel, TrashVoidColdsteel },
            { ArcDPSEnums.TrashID.VoidColdsteel2, TrashVoidColdsteel },
            { ArcDPSEnums.TrashID.VoidColdsteel3, TrashVoidColdsteel },
            { ArcDPSEnums.TrashID.VoidTangler, TrashVoidTangler },
            { ArcDPSEnums.TrashID.VoidTangler2, TrashVoidTangler },
            { ArcDPSEnums.TrashID.VoidObliterator, TrashVoidObliterator },
            { ArcDPSEnums.TrashID.VoidObliterator2, TrashVoidObliterator },
            { ArcDPSEnums.TrashID.VoidGoliath, TrashVoidGoliath },
            { ArcDPSEnums.TrashID.VoidBrandbomber, TrashVoidBrandbomber },
            { ArcDPSEnums.TrashID.VoidSkullpiercer, TrashVoidSkullpiercer },
            { ArcDPSEnums.TrashID.VoidTimeCaster, TrashVoidTimeCaster },
            { ArcDPSEnums.TrashID.VoidTimeCaster2, TrashVoidTimeCaster },
            { ArcDPSEnums.TrashID.VoidThornheart1, TrashVoidThornheart },
            { ArcDPSEnums.TrashID.VoidThornheart2, TrashVoidThornheart },
            { ArcDPSEnums.TrashID.VoidBrandfang1, TrashVoidBrandfang },
            { ArcDPSEnums.TrashID.VoidBrandfang2, TrashVoidBrandfang },
            { ArcDPSEnums.TrashID.VoidBrandbeast, TrashVoidBrandbeast },
            { ArcDPSEnums.TrashID.VoidBrandscale1, TrashVoidBrandscale },
            { ArcDPSEnums.TrashID.VoidBrandscale2, TrashVoidBrandscale },
            { ArcDPSEnums.TrashID.VoidFrostwing, TrashVoidFrostwing },
            //{ ArcDPSEnums.TrashID.CastleFountain, TrashCastleFountain },
            { ArcDPSEnums.TrashID.HauntingStatue, TrashHauntingStatue },
            { ArcDPSEnums.TrashID.GreenKnight, TrashRGBKnight },
            { ArcDPSEnums.TrashID.RedKnight, TrashRGBKnight },
            { ArcDPSEnums.TrashID.BlueKnight, TrashRGBKnight },
            { ArcDPSEnums.TrashID.CloneArtsariiv, TrashCloneArtsariiv },
            { ArcDPSEnums.TrashID.MaiTrinStrikeDuringEcho, TrashMaiTrinStrikeDuringEcho },
            { ArcDPSEnums.TrashID.SooWonTail, TrashSooWonTail },
            { ArcDPSEnums.TrashID.TheEnforcer, TrashTheEnforcer },
            { ArcDPSEnums.TrashID.TheEnforcerCM, TrashTheEnforcer },
            { ArcDPSEnums.TrashID.TheMechRider, TrashTheMechRider },
            { ArcDPSEnums.TrashID.TheMechRiderCM, TrashTheMechRider },
            { ArcDPSEnums.TrashID.TheMindblade, TrashTheMindblade },
            { ArcDPSEnums.TrashID.TheMindbladeCM, TrashTheMindblade },
            { ArcDPSEnums.TrashID.TheRitualist, TrashTheRitualist },
            { ArcDPSEnums.TrashID.TheRitualistCM, TrashTheRitualist },
            { ArcDPSEnums.TrashID.TheSniper, TrashTheSniper },
            { ArcDPSEnums.TrashID.TheSniperCM, TrashTheSniper },
            { ArcDPSEnums.TrashID.PushableVoidAmalgamate, TrashVoidAmalgamate },
            { ArcDPSEnums.TrashID.KillableVoidAmalgamate, TrashVoidAmalgamate },
        };

        /// <summary>
        /// Dictionary matching a <see cref="ArcDPSEnums.MinionID"/> to their icon.
        /// </summary>
        internal static IReadOnlyDictionary<ArcDPSEnums.MinionID, string> MinionNPCIcons { get; private set; } = new Dictionary<ArcDPSEnums.MinionID, string>()
        {
            { ArcDPSEnums.MinionID.RuneJaggedHorror, MinionRuneJaggedHorror },
            { ArcDPSEnums.MinionID.RuneMarkIGolem, MinionRuneMarkIGolem },
            { ArcDPSEnums.MinionID.Clone1, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone2, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone3, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone4, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone5, MinionMesmerClone },
            { ArcDPSEnums.MinionID.CloneStaff, MinionMesmerClone },
            { ArcDPSEnums.MinionID.CloneDownstate, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone8, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone9, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone10, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone11, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone12, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone13, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone14, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone15, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone16, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone17, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone18, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone19, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone20, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone21, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone22, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone23, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone24, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone25, MinionMesmerClone },
            { ArcDPSEnums.MinionID.Clone26, MinionMesmerClone },
            { ArcDPSEnums.MinionID.IllusionarySwordsman, MinionIllusionarySwordsman },
            { ArcDPSEnums.MinionID.IllusionaryBerserker, MinionIllusionaryBerserker },
            { ArcDPSEnums.MinionID.IllusionaryDisenchanter, MinionIllusionaryDisenchanter },
            { ArcDPSEnums.MinionID.IllusionaryRogue, MinionIllusionaryRogue },
            { ArcDPSEnums.MinionID.IllusionaryDefender, MinionIllusionaryDefender },
            { ArcDPSEnums.MinionID.IllusionaryMage, MinionIllusionaryMage },
            { ArcDPSEnums.MinionID.IllusionaryDuelist, MinionIllusionaryDuelist },
            { ArcDPSEnums.MinionID.IllusionaryWarden, MinionIllusionaryWarden },
            { ArcDPSEnums.MinionID.IllusionaryWarlock, MinionIllusionaryWarlock },
            { ArcDPSEnums.MinionID.IllusionaryAvenger, MinionIllusionaryAvenger },
            { ArcDPSEnums.MinionID.JadeMech, MinionJadeMech },
            { ArcDPSEnums.MinionID.EraBreakrazor, MinionEraBreakrazor },
            { ArcDPSEnums.MinionID.KusDarkrazor, MinionKusDarkrazor },
            { ArcDPSEnums.MinionID.ViskIcerazor, MinionViskIcerazor },
            { ArcDPSEnums.MinionID.JasRazorclaw, MinionJasRazorclaw },
            { ArcDPSEnums.MinionID.OfelaSoulcleave, MinionOfelaSoulcleave },
            { ArcDPSEnums.MinionID.VentariTablet, MinionVentariTablet },
            { ArcDPSEnums.MinionID.FrostSpirit, MinionFrostSpirit },
            { ArcDPSEnums.MinionID.SunSpirit, MinionSunSpirit },
            { ArcDPSEnums.MinionID.SpiritOfNatureRenewal, MinionSpiritOfNatureRenewal },
            { ArcDPSEnums.MinionID.StoneSpirit, MinionStoneSpirit },
            { ArcDPSEnums.MinionID.StormSpirit, MinionStormSpirit },
            { ArcDPSEnums.MinionID.JuvenileAlpineWolf, MinionJuvenileAlpineWolf },
            { ArcDPSEnums.MinionID.JuvenileArctodus, MinionJuvenileArctodus },
            { ArcDPSEnums.MinionID.JuvenileArmorFish, MinionJuvenileArmorFish },
            { ArcDPSEnums.MinionID.JuvenileBlackBear, MinionJuvenileBlackBear },
            { ArcDPSEnums.MinionID.JuvenileBlackMoa, MinionJuvenileBlackMoa },
            { ArcDPSEnums.MinionID.JuvenileBlackWidowSpider, MinionJuvenileBlackWidowSpider },
            { ArcDPSEnums.MinionID.JuvenileBlueJellyfish, MinionJuvenileBlueRainbowJellyfish },
            { ArcDPSEnums.MinionID.JuvenileRainbowJellyfish, MinionJuvenileBlueRainbowJellyfish },
            { ArcDPSEnums.MinionID.JuvenileBlueMoa, MinionJuvenileBlueMoa },
            { ArcDPSEnums.MinionID.JuvenileBoar, MinionJuvenileBoar },
            { ArcDPSEnums.MinionID.JuvenileBristleback, MinionJuvenileBristleback },
            { ArcDPSEnums.MinionID.JuvenileBrownBear, MinionJuvenileBrownBear },
            { ArcDPSEnums.MinionID.JuvenileCheetah, MinionJuvenileCheetah },
            { ArcDPSEnums.MinionID.JuvenileEagle, MinionJuvenileEagle },
            { ArcDPSEnums.MinionID.JuvenileEletricWywern, MinionJuvenileEletricWywern },
            { ArcDPSEnums.MinionID.JuvenileFangedIboga, MinionJuvenileFangedIboga },
            { ArcDPSEnums.MinionID.JuvenileFernHound, MinionJuvenileFernHound },
            { ArcDPSEnums.MinionID.JuvenileFireWywern, MinionJuvenileFireWywern },
            { ArcDPSEnums.MinionID.JuvenileForestSpider, MinionJuvenileForestSpider },
            { ArcDPSEnums.MinionID.JuvenileIceDrake, MinionJuvenileIceDrake },
            { ArcDPSEnums.MinionID.JuvenileJacaranda, MinionJuvenileJacaranda },
            { ArcDPSEnums.MinionID.JuvenileJungleSpider, MinionJuvenileJungleSpider },
            { ArcDPSEnums.MinionID.JuvenileJungleStalker, MinionJuvenileJungleStalker },
            { ArcDPSEnums.MinionID.JuvenileKrytanDrakehound, MinionJuvenileKrytanDrakehound },
            { ArcDPSEnums.MinionID.JuvenileLashtailDevourer, MinionJuvenileLashtailDevourer },
            { ArcDPSEnums.MinionID.JuvenileLynx, MinionJuvenileLynx },
            { ArcDPSEnums.MinionID.JuvenileMarshDrake, MinionJuvenileMarshDrake },
            { ArcDPSEnums.MinionID.JuvenileOwl, MinionJuvenileOwl },
            { ArcDPSEnums.MinionID.JuvenilePig, MinionJuvenilePig },
            { ArcDPSEnums.MinionID.JuvenilePinkMoa, MinionJuvenilePinkMoa },
            { ArcDPSEnums.MinionID.JuvenileRedJellyfish, MinionJuvenileRedJellyfish },
            { ArcDPSEnums.MinionID.JuvenileRedMoa, MinionJuvenileRedMoa },
            { ArcDPSEnums.MinionID.JuvenileRiverDrake, MinionJuvenileRiverDrake },
            { ArcDPSEnums.MinionID.JuvenileRockGazelle, MinionJuvenileRockGazelle },
            { ArcDPSEnums.MinionID.JuvenileSalamanderDraker, MinionJuvenileSalamanderDraker},
            { ArcDPSEnums.MinionID.JuvenileSandLion, MinionJuvenileSandLion },
            { ArcDPSEnums.MinionID.JuvenileWhiteTiger, MinionJuvenileWhiteTiger },
            { ArcDPSEnums.MinionID.JuvenileShark, MinionJuvenileShark },
            { ArcDPSEnums.MinionID.JuvenileSmokescale, MinionJuvenileSmokescale },
            { ArcDPSEnums.MinionID.JuvenileTiger, MinionJuvenileTiger },
            { ArcDPSEnums.MinionID.JuvenileWarthog, MinionJuvenileWarthog },
            { ArcDPSEnums.MinionID.JuvenileWhiptailDevourer, MinionJuvenileWhiptailDevourer},
            { ArcDPSEnums.MinionID.JuvenileWolf, MinionJuvenileWolf },
            { ArcDPSEnums.MinionID.BloodFiend, MinionBloodFiend },
            { ArcDPSEnums.MinionID.BoneFiend, MinionBoneFiend },
            { ArcDPSEnums.MinionID.FleshGolem, MinionFleshGolem },
            { ArcDPSEnums.MinionID.ShadowFiend, MinionShadowFiend },
            { ArcDPSEnums.MinionID.FleshWurm, MinionFleshWurm },
            { ArcDPSEnums.MinionID.UnstableHorror, MinionUnstableHorror },
            { ArcDPSEnums.MinionID.ShamblingHorror, MinionShamblingHorror },
            { ArcDPSEnums.MinionID.Thief1, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief2, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief3, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief4, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief5, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief6, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief7, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief8, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief9, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief10, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief11, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief12, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief13, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief14, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief15, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief16, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief17, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief18, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief19, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief20, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief21, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Thief22, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil1, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil2, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil3, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil4, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil5, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil6, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil7, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil8, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil9, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Daredevil10, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye1, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye2, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye3, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye4, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye5, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye6, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye7, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye8, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye9, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.Deadeye10, MinionThiefDaredevilDeadeye },
            { ArcDPSEnums.MinionID.BowOfTruth, MinionBowOfTruth },
            { ArcDPSEnums.MinionID.HammerOfWisdom, MinionHammerOfWisdom },
            { ArcDPSEnums.MinionID.ShieldOfTheAvenger, MinionShieldOfTheAvenger },
            { ArcDPSEnums.MinionID.SwordOfJustice, MinionSwordOfJustice },
            { ArcDPSEnums.MinionID.LesserAirElemental, MinionLesserAirElemental },
            { ArcDPSEnums.MinionID.LesserEarthElemental, MinionLesserEarthElemental },
            { ArcDPSEnums.MinionID.LesserFireElemental, MinionLesserFireElemental },
            { ArcDPSEnums.MinionID.LesserIceElemental, MinionLesserIceElemental },
            { ArcDPSEnums.MinionID.AirElemental, MinionAirElemental },
            { ArcDPSEnums.MinionID.EarthElemental, MinionEarthElemental },
            { ArcDPSEnums.MinionID.FireElemental, MinionFireElemental },
            { ArcDPSEnums.MinionID.IceElemental, MinionIceElemental },
        };
    }
}
