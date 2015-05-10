﻿using UnityEngine;
using System;
using UniRx;
using Zenject;

namespace Submarine
{
    public class BattleController : IInitializable, IDisposable, ITickable
    {
        readonly BattleInstaller.Settings settings;
        readonly ConnectionService connection;
        readonly BattleService battleService;
        readonly BattleObjectContainer objectContainer;
        readonly ThirdPersonCamera thirdPersonCamera;

        private PlayerSubmarine playerSubmarine;

        public BattleController(
            BattleInstaller.Settings settings,
            ConnectionService connection,
            BattleService battleService,
            BattleObjectContainer objectContainer,
            ThirdPersonCamera thirdPersonCamera)
        {
            this.settings = settings;
            this.connection = connection;
            this.battleService = battleService;
            this.objectContainer = objectContainer;
            this.thirdPersonCamera = thirdPersonCamera;
        }

        public void Initialize()
        {
            if (!connection.InRoom) { return; }

            battleService.StartBattle();

            playerSubmarine = objectContainer.SpawnPlayerSubmarine(settings.Map.StartPositions[0]);
            thirdPersonCamera.SetTarget(playerSubmarine.Hooks.transform);
            playerSubmarine.Resources.CanUsePinger.SubscribeToInteractable(settings.UI.PingerButton);
        }

        public void Dispose()
        {
            battleService.FinishBattle();
        }

        public void Tick()
        {
            MoveToTitleUnlessInRoom();
            UpdateTimerText();
            UpdateDebugText();
        }

        void UpdateTimerText()
        {
            var elapsedTimeSpan = DateTime.Now - battleService.StartDateTime;
            settings.UI.TimerText.text = string.Format(
                "{0:00}:{1:00}",
                elapsedTimeSpan.TotalMinutes,
                elapsedTimeSpan.Seconds
            );
        }

        void UpdateDebugText()
        {
            settings.UI.BattleLogText.text = string.Format(
                "{0:0.0} FPS\nPlayerId: {1:D} ({2})",
                Constants.Fps,
                connection.Player.ID,
                connection.Player.isMasterClient ? "Master" : "Slave"
            );
        }

        void MoveToTitleUnlessInRoom()
        {
            if (!connection.InRoom)
            {
                Debug.Log("Not in room");
                ZenUtil.LoadScene(Constants.SceneNames.Title);
            }
        }
    }
}
