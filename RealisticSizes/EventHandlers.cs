﻿using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using UnityEngine;

namespace RealisticSizes.Handlers
{
    public class EventHandlers
    {
        public RealisticSizes plugin;
        public EventHandlers(RealisticSizes plugin) => this.plugin = plugin;

        private static readonly System.Random random = new System.Random();

        float randScale;
        float fatScale;

        private static float RandomFloatBetween(float minValue, float maxValue)
        {
            var next = random.Next();
            return minValue + (next * (maxValue - minValue));
        }

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player != null)
            {
                try
                {
                    if (plugin.Config.FunMode)
                    {
                        randScale = RandomFloatBetween(0.85f, 1.03f);
                        fatScale = RandomFloatBetween(0.8f, 1.12f);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        randScale = RandomFloatBetween(0.9f, 1.03f);
                        fatScale = RandomFloatBetween(0.9f, 1.12f);
                    }
                    switch (ev.NewRole)
                    {
                        case RoleType.Spectator:
                        case RoleType.Tutorial:
                            ev.Player.Scale = new Vector3(1, 1, 1);
                            SpawnPlayer(ev.Player, randScale, fatScale);
                            return;
                        case RoleType.ClassD:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.ClassDMinHeight, plugin.Config.ClassDMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.ClassDMinWidth, plugin.Config.ClassDMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scientist:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.ScientistMinHeight, plugin.Config.ScientistMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.ScientistMinWidth, plugin.Config.ScientistMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.FacilityGuard:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.FacilityGuardMinHeight, plugin.Config.FacilityGuardMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.FacilityGuardMinWidth, plugin.Config.FacilityGuardMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.NtfCadet:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.NTFCadetMinHeight, plugin.Config.NTFCadetMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.NTFCadetMinWidth, plugin.Config.NTFCadetMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.NtfLieutenant:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.NTFLieutenantMinHeight, plugin.Config.NTFLieutenantMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.NTFLieutenantMinWidth, plugin.Config.NTFLieutenantMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.NtfCommander:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.CommanderMinHeight, plugin.Config.CommanderMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.CommanderMinWidth, plugin.Config.CommanderMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.ChaosInsurgency:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.ChaosInsurgencyMinHeight, plugin.Config.ChaosInsurgencyMaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.ChaosInsurgencyMinWidth, plugin.Config.ChaosInsurgencyMaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp049:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp049MinHeight, plugin.Config.Scp049MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp049MinWidth, plugin.Config.Scp049MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp0492:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp0492MinHeight, plugin.Config.Scp0492MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp0492MinWidth, plugin.Config.Scp0492MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp096:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp096MinHeight, plugin.Config.Scp096MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp096MinWidth, plugin.Config.Scp096MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp106:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp106MinHeight, plugin.Config.Scp106MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp106MinWidth, plugin.Config.Scp106MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp173:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp173MinHeight, plugin.Config.Scp173MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp173MinWidth, plugin.Config.Scp173MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp93953:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp93953MinHeight, plugin.Config.Scp93953MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp93953MinWidth, plugin.Config.Scp93953MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                        case RoleType.Scp93989:
                            if (plugin.Config.ManualSizes)
                            {
                                randScale = RandomFloatBetween(plugin.Config.Scp93989MinHeight, plugin.Config.Scp93989MaxHeight);
                                fatScale = RandomFloatBetween(plugin.Config.Scp93989MinWidth, plugin.Config.Scp93989MaxWidth);
                                SpawnPlayer(ev.Player, randScale, fatScale);
                            }
                            return;
                    }
                }
                catch (Exception e)
                {
                    Log.Error("Realistic sizes: "+ e);
                }
            }
        }
        
        public void SpawnPlayer(Player ply, float Scale1, float Scale2)
        {
            ply.Scale = new Vector3(Scale1, Scale2, Scale2);
        }
    }
}