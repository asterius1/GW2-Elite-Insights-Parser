﻿using System.Collections.Generic;
using System.Linq;
using GW2EIEvtcParser.ParsedData;

namespace GW2EIEvtcParser.EIData
{
    internal class BuffGainCastFinder : BuffCastFinder
    {

        public delegate bool BuffGainCastChecker(BuffApplyEvent evt, CombatData combatData, AgentData agentData, SkillData skillData);
        private BuffGainCastChecker _triggerCondition { get; set; }

        protected virtual AgentItem GetCasterAgent(AgentItem agent)
        {
            return agent;
        }

        public BuffGainCastFinder(long skillID, long buffID) : base(skillID, buffID)
        {
        }

        internal BuffGainCastFinder UsingChecker(BuffGainCastChecker checker)
        {
            _triggerCondition = checker;
            return this;
        }

        public override List<InstantCastEvent> ComputeInstantCast(CombatData combatData, SkillData skillData, AgentData agentData)
        {
            var res = new List<InstantCastEvent>();
            var applies = combatData.GetBuffData(BuffID).OfType<BuffApplyEvent>().GroupBy(x => x.To).ToDictionary(x => x.Key, x => x.ToList());
            foreach (KeyValuePair<AgentItem, List<BuffApplyEvent>> pair in applies)
            {
                long lastTime = int.MinValue;
                foreach (BuffApplyEvent bae in pair.Value)
                {
                    if (bae.Initial)
                    {
                        continue;
                    }
                    if (bae.Time - lastTime < ICD)
                    {
                        lastTime = bae.Time;
                        continue;
                    }
                    if (_triggerCondition == null || _triggerCondition(bae, combatData, agentData, skillData))
                    {
                        lastTime = bae.Time;
                        AgentItem caster = GetCasterAgent(bae.To);
                        res.Add(new InstantCastEvent(GetTime(bae, caster,combatData), skillData.Get(SkillID), caster));
                    }
                }
            }

            return res;
        }
    }
}
