﻿using System.Collections.Generic;
using GW2EIEvtcParser.ParsedData;

namespace GW2EIEvtcParser.EIData
{

    internal class EnemyDstBuffApplyMechanic : EnemyBuffApplyMechanic
    {

        public EnemyDstBuffApplyMechanic(long mechanicID, string inGameName, MechanicPlotlySetting plotlySetting, string shortName, string description, string fullName, int internalCoolDown, BuffApplyChecker condition = null) : base(mechanicID , inGameName, plotlySetting, shortName, description, fullName, internalCoolDown, condition)
        {
        }

        public EnemyDstBuffApplyMechanic(long[] mechanicIDs, string inGameName, MechanicPlotlySetting plotlySetting, string shortName, string description, string fullName, int internalCoolDown, BuffApplyChecker condition = null) : base(mechanicIDs, inGameName, plotlySetting, shortName, description, fullName, internalCoolDown, condition)
        {
        }

        protected override AgentItem GetAgentItem(BuffApplyEvent ba)
        {
            return ba.To;
        }

        internal override void CheckMechanic(ParsedEvtcLog log, Dictionary<Mechanic, List<MechanicEvent>> mechanicLogs, Dictionary<int, AbstractSingleActor> regroupedMobs)
        {
            foreach (long mechanicID in MechanicIDs)
            {
                foreach (AbstractBuffEvent c in log.CombatData.GetBuffData(mechanicID))
                {
                    AbstractSingleActor amp = null;
                    if (c is BuffApplyEvent ba && Keep(ba, log))
                    {
                        amp = MechanicHelper.FindEnemyActor(log, ba.To, regroupedMobs);
                    }
                    if (amp != null)
                    {
                        mechanicLogs[this].Add(new MechanicEvent(c.Time, this, amp));
                    }
                }
            }
        }
    }
}
