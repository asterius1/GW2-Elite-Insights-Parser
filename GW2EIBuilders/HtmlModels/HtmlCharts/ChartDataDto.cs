﻿using System;
using System.Collections.Generic;
using System.Linq;
using GW2EIEvtcParser;
using GW2EIEvtcParser.EIData;

namespace GW2EIBuilders.HtmlModels
{
    internal class ChartDataDto
    {
        public List<PhaseChartDataDto> Phases { get; set; } = new List<PhaseChartDataDto>();
        public List<MechanicChartDataDto> Mechanics { get; set; } = new List<MechanicChartDataDto>();

        private static List<object[]> BuildGraphStates(List<Segment> segments, PhaseData phase, bool nullable, double defaultState)
        {
            if (!segments.Any())
            {
                return nullable ? null : new List<object[]>()
                {
                    new object[] { Math.Round(phase.Start/1000.0, 3), defaultState},
                    new object[] { Math.Round(phase.End/1000.0, 3), defaultState},
                };
            }
            var res = new List<object[]>();
            var subSegments = segments.Where(x => x.End >= phase.Start && x.Start <= phase.End
            ).ToList();
            return Segment.ToObjectList(subSegments, phase.Start, phase.End);
        }

        public static List<object[]> BuildHealthStates(ParsedEvtcLog log, AbstractSingleActor actor, PhaseData phase, bool nullable)
        {
            return BuildGraphStates(actor.GetHealthUpdates(log), phase, nullable, 100.0);
        }

        public static List<object[]> BuildBarrierStates(ParsedEvtcLog log, AbstractSingleActor actor, PhaseData phase)
        {
            return BuildGraphStates(actor.GetBarrierUpdates(log), phase, true, 0.0);
        }

        public static List<object[]> BuildBreakbarPercentStates(ParsedEvtcLog log, NPC npc, PhaseData phase)
        {
            return BuildGraphStates(npc.GetBreakbarPercentUpdates(log), phase, true, 100.0);
        }

        public static ChartDataDto BuildChartData(ParsedEvtcLog log)
        {
            var chartData = new ChartDataDto();
            var phaseChartData = new List<PhaseChartDataDto>();
            IReadOnlyList<PhaseData> phases = log.FightData.GetPhases(log);
            for (int i = 0; i < phases.Count; i++)
            {
                var phaseData = new PhaseChartDataDto()
                {
                    Players = PlayerChartDataDto.BuildPlayersGraphData(log, i)
                };
                foreach (NPC target in phases[i].Targets)
                {
                    phaseData.Targets.Add(TargetChartDataDto.BuildTargetGraphData(log, i, target));
                }
                if (i == 0)
                {
                    phaseData.TargetsHealthStatesForCR = new List<List<object[]>>();
                    phaseData.TargetsBreakbarPercentStatesForCR = new List<List<object[]>>();
                    phaseData.TargetsBarrierStatesForCR = new List<List<object[]>>();
                    foreach (NPC target in log.FightData.Logic.Targets)
                    {
                        phaseData.TargetsHealthStatesForCR.Add(BuildHealthStates(log, target, phases[0], false));
                        phaseData.TargetsBreakbarPercentStatesForCR.Add(BuildBreakbarPercentStates(log, target, phases[0]));
                        phaseData.TargetsBarrierStatesForCR.Add(BuildBarrierStates(log, target, phases[0]));
                    }
                }

                phaseChartData.Add(phaseData);
            }
            chartData.Phases = phaseChartData;
            chartData.Mechanics = MechanicChartDataDto.BuildMechanicsChartData(log);
            return chartData;
        }
    }
}
