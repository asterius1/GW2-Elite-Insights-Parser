﻿
using System.Collections.Generic;
using System.Linq;
using GW2EIEvtcParser.ParsedData;
using static GW2EIEvtcParser.EncounterLogic.EncounterCategory;

namespace GW2EIEvtcParser.EncounterLogic
{
    internal abstract class CanthaStrike : StrikeMissionLogic
    {
        public CanthaStrike(int triggerID) : base(triggerID)
        {
            EncounterCategoryInformation.SubCategory = SubFightCategory.Cantha;
        }

        internal override void CheckSuccess(CombatData combatData, AgentData agentData, FightData fightData, IReadOnlyCollection<AgentItem> playerAgents)
        {
            IReadOnlyList<RewardEvent> rewards = combatData.GetRewardEvents();
            RewardEvent reward = rewards.FirstOrDefault(x => x.RewardType == 29453);
            if (reward != null)
            {
                fightData.SetSuccess(true, reward.Time);
            }
            else
            {
                SetSuccessByDeath(combatData, fightData, playerAgents, true);
            }
        }
    }
}
