﻿using System.Collections.Generic;
using System.Linq;
using GW2EIEvtcParser.EIData;
using GW2EIEvtcParser.ParsedData;
using static GW2EIEvtcParser.SkillIDs;
using static GW2EIEvtcParser.EncounterLogic.EncounterLogicUtils;
using static GW2EIEvtcParser.EncounterLogic.EncounterLogicPhaseUtils;
using static GW2EIEvtcParser.EncounterLogic.EncounterLogicTimeUtils;
using static GW2EIEvtcParser.EncounterLogic.EncounterImages;
using GW2EIEvtcParser.Exceptions;
using System;
using GW2EIEvtcParser.Extensions;

namespace GW2EIEvtcParser.EncounterLogic
{
    internal class Escort : StrongholdOfTheFaithful
    {
        private static readonly Point3D SiegeChestPosition = new Point3D(-3815.47f, 16688.5f, -5322.35f);
        private bool _hasPreEvent = false;
        public Escort(int triggerID) : base(triggerID)
        {
            MechanicList.AddRange(new List<Mechanic>
            {

            }
            );
            ChestID = ArcDPSEnums.ChestID.SiegeChest;
            Extension = "escort";
            Icon = EncounterIconEscort;
            EncounterCategoryInformation.InSubCategoryOrder = 0;
            GenericFallBackMethod = FallBackMethod.ChestGadget;
            EncounterID |= 0x000001;
        }

        protected override CombatReplayMap GetCombatMapInternal(ParsedEvtcLog log)
        {
            return new CombatReplayMap(CombatReplayEscort,
                            (1080, 676),
                            (-6081.86, 13624.72, 8956.86, 23099.28));
        }

        internal override string GetLogicName(CombatData combatData, AgentData agentData)
        {
            return "Siege the Stronghold";
        }

        private IReadOnlyList<PhaseData> GetMcLeodPhases(AbstractSingleActor mcLeod, ParsedEvtcLog log)
        {
            var phases = new List<PhaseData>();
            //
            DeadEvent mcLeodDeath = log.CombatData.GetDeadEvents(mcLeod.AgentItem).LastOrDefault();
            long mcLeodStart = Math.Max(mcLeod.FirstAware, log.FightData.FightStart);
            long mcLeodEnd = Math.Min(mcLeodDeath != null ? mcLeodDeath.Time : mcLeod.LastAware, log.FightData.FightEnd);
            var mainPhase = new PhaseData(mcLeodStart, mcLeodEnd)
            {
                Name = "McLeod The Silent"
            };
            mainPhase.AddTarget(mcLeod);
            phases.Add(mainPhase);
            //
            phases.AddRange(GetPhasesByInvul(log, Invulnerability757, mcLeod, true, true, mcLeodStart, mcLeodEnd));
            for (int i = 1; i < phases.Count; i++)
            {
                PhaseData phase = phases[i];
                if (i % 2 == 0)
                {
                    phase.Name = "McLeod Split " + (i) / 2;
                    AbstractSingleActor whiteMcLeod = Targets.FirstOrDefault(x => x.IsSpecy(ArcDPSEnums.TrashID.RadiantMcLeod) && x.LastAware > phase.Start);
                    AbstractSingleActor redMcLeod = Targets.FirstOrDefault(x => x.IsSpecy(ArcDPSEnums.TrashID.CrimsonMcLeod) && x.LastAware > phase.Start);
                    phase.AddTarget(whiteMcLeod); 
                    phase.AddTarget(redMcLeod);
                    phase.OverrideTimes(log);
                }
                else
                {
                    phase.Name = "McLeod Phase " + (i + 1) / 2;
                    phase.AddTarget(mcLeod);
                }
            }
            //
            return phases;
        }

        internal override List<PhaseData> GetPhases(ParsedEvtcLog log, bool requirePhases)
        {
            List<PhaseData> phases = GetInitialPhase(log);
            AbstractSingleActor mcLeod = Targets.FirstOrDefault(x => x.ID == (int)ArcDPSEnums.TargetID.McLeodTheSilent);
            if (mcLeod == null)
            {
                throw new MissingKeyActorsException("McLeod not found");
            }
            phases[0].AddTarget(mcLeod);
            if (!requirePhases)
            {
                return phases;
            }
            IReadOnlyList<AbstractSingleActor> wargs = Targets.Where(x => x.IsSpecy(ArcDPSEnums.TrashID.WargBloodhound)).ToList();
            if (_hasPreEvent)
            {
                var preEventWargs = wargs.Where(x => x.FirstAware <= mcLeod.LastAware).ToList();
                var preEventPhase = new PhaseData(log.FightData.FightStart, mcLeod.FirstAware - 1)
                {
                    Name = "Escort",
                };
                preEventPhase.AddTargets(preEventWargs);
                preEventPhase.AddTarget(Targets.FirstOrDefault(x => x.ID == (int)ArcDPSEnums.TargetID.DummyTarget));
                phases.Add(preEventPhase);
            } 
            phases.AddRange(GetMcLeodPhases(mcLeod, log));
            var mcLeodWargs = wargs.Where(x => x.FirstAware >= mcLeod.FirstAware && x.FirstAware <= mcLeod.LastAware).ToList();
            if (mcLeodWargs.Any())
            {
                var phase = new PhaseData(log.FightData.FightStart, log.FightData.FightEnd)
                {
                    Name = "McLeod Wargs",
                    CanBeSubPhase = false,
                };
                phase.AddTargets(mcLeodWargs);
                phase.OverrideTimes(log);
                phases.Add(phase);
            }
            
            return phases;
        }

        internal override void EIEvtcParse(ulong gw2Build, FightData fightData, AgentData agentData, List<CombatItem> combatData, IReadOnlyDictionary<uint, AbstractExtensionHandler> extensions)
        {
            AgentItem mcLeod = agentData.GetNPCsByID(ArcDPSEnums.TargetID.McLeodTheSilent).FirstOrDefault();
            if (mcLeod == null)
            {
                throw new MissingKeyActorsException("McLeod not found");
            }
            bool needsRefresh = FindChestGadget(ChestID, agentData, combatData, SiegeChestPosition, (agentItem) => agentItem.HitboxHeight == 1200 && agentItem.HitboxWidth == 100);
            //
            var mineAgents = combatData.Where(x => x.DstAgent == 1494 && x.IsStateChange == ArcDPSEnums.StateChange.MaxHealthUpdate).Select(x => agentData.GetAgent(x.SrcAgent, x.Time)).Where(x => x.Type == AgentItem.AgentType.Gadget && x.HitboxWidth == 100 && x.HitboxHeight == 300).ToList();
            foreach (AgentItem mine in mineAgents)
            {
                mine.OverrideID(ArcDPSEnums.TrashID.Mine);
                mine.OverrideType(AgentItem.AgentType.NPC);
            }
            // to keep the pre event as we need targets
            if (_hasPreEvent && !agentData.GetNPCsByID(ArcDPSEnums.TrashID.WargBloodhound).Any(x => x.FirstAware < mcLeod.FirstAware))
            {
                agentData.AddCustomNPCAgent(fightData.FightStart, fightData.FightEnd, "Escort", ParserHelper.Spec.NPC, ArcDPSEnums.TargetID.DummyTarget, true);
                needsRefresh = false;
            }
            if (needsRefresh)
            {
                agentData.Refresh();
            }
            base.EIEvtcParse(gw2Build, fightData, agentData, combatData, extensions);
            int curCrimson = 1;
            int curRadiant = 1;
            int curWarg = 1;
            foreach (AbstractSingleActor target in Targets)
            {
                if (target.IsSpecy(ArcDPSEnums.TrashID.WargBloodhound))
                {
                    target.OverrideName(target.Character + " " + curWarg++);
                }
                if (target.IsSpecy(ArcDPSEnums.TrashID.CrimsonMcLeod))
                {
                    target.OverrideName("Crimson " + target.Character + " " + curCrimson++);
                }
                if (target.IsSpecy(ArcDPSEnums.TrashID.RadiantMcLeod))
                {
                    target.OverrideName("Radiant " + target.Character + " " + curRadiant++);
                }
            }
        }

        internal override long GetFightOffset(FightData fightData, AgentData agentData, List<CombatItem> combatData)
        {
            AgentItem mcLeod = agentData.GetNPCsByID(ArcDPSEnums.TargetID.McLeodTheSilent).FirstOrDefault();
            if (mcLeod == null)
            {
                throw new MissingKeyActorsException("McLeod not found");
            }
            long startToUse = GetGenericFightOffset(fightData);
            CombatItem logStartNPCUpdate = combatData.FirstOrDefault(x => x.IsStateChange == ArcDPSEnums.StateChange.LogStartNPCUpdate);
            if (logStartNPCUpdate != null)
            {
                if (mcLeod.FirstAware - fightData.LogStart > ParserHelper.MinimumInCombatDuration)
                {
                    _hasPreEvent = true;
                } 
                else
                {
                    startToUse = GetEnterCombatTime(fightData, agentData, combatData, logStartNPCUpdate.Time);
                }
            }
            return startToUse;
        }

        protected override HashSet<int> GetUniqueNPCIDs()
        {
            return new HashSet<int>
            {
                (int)ArcDPSEnums.TargetID.McLeodTheSilent,
                (int)ArcDPSEnums.TrashID.Glenna
            };
        }
        protected override List<int> GetTargetsIDs()
        {
            return new List<int>
            {
                (int)ArcDPSEnums.TargetID.McLeodTheSilent,
                (int)ArcDPSEnums.TargetID.DummyTarget,
                (int)ArcDPSEnums.TrashID.WargBloodhound,
                (int)ArcDPSEnums.TrashID.RadiantMcLeod,
                (int)ArcDPSEnums.TrashID.CrimsonMcLeod,
            };
        }

        protected override List<ArcDPSEnums.TrashID> GetTrashMobsIDs()
        {
            return new List<ArcDPSEnums.TrashID>() { 
                ArcDPSEnums.TrashID.MushroomCharger,
                ArcDPSEnums.TrashID.MushroomKing,
                ArcDPSEnums.TrashID.MushroomSpikeThrower,
                ArcDPSEnums.TrashID.WhiteMantleBattleMage,
                ArcDPSEnums.TrashID.WhiteMantleBattleCultist,
                ArcDPSEnums.TrashID.WhiteMantleBattleKnight1,
                ArcDPSEnums.TrashID.WhiteMantleBattleKnight2,
                ArcDPSEnums.TrashID.WhiteMantleBattleCleric1,
                ArcDPSEnums.TrashID.WhiteMantleBattleCleric2,
                ArcDPSEnums.TrashID.WhiteMantleBattleSeeker1,
                ArcDPSEnums.TrashID.WhiteMantleBattleSeeker2,
                ArcDPSEnums.TrashID.Mine,
            };
        }

        protected override List<int> GetFriendlyNPCIDs()
        {
            return new List<int>
            {
                (int)ArcDPSEnums.TrashID.Glenna
            };
        }
    }
}
