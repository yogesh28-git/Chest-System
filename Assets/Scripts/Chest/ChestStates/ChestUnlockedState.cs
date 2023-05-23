using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ChestSystem.Chest;

namespace ChestSystem
{
    public class ChestUnlockedState : IChestState
    {
        private ChestController chestController;

        public ChestUnlockedState( ChestController chestController )
        {
            this.chestController = chestController;
        }
        public void OnStateEnable( )
        {
            chestController.ChestView.TopText.text = "Unlocked";
        }
        public void ChestButtonAction( )
        {

        }
        public void OnStateDisable( )
        {

        }
        public ChestState GetChestState( )
        {
            return ChestState.UNLOCKED;
        }
    }
}