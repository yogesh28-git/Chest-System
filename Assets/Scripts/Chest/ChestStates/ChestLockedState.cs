using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ChestSystem.Chest;

namespace ChestSystem
{
    public class ChestLockedState : IChestState
    {
        private ChestController chestController;
        private int unlockDurationMinutes;
        private Button unlockNowButton;
        private Button setTimerButton;

        public ChestLockedState( ChestController chestController )
        {
            this.chestController = chestController;
            unlockNowButton = UIService.Instance.UnlockNowButton;
            setTimerButton = UIService.Instance.SetTimerButton;

            unlockNowButton.onClick.AddListener( chestController.UnlockNow );
            setTimerButton.onClick.AddListener( chestController.StartUnlocking );
        }
        public void OnStateEnable( )
        {
            chestController.ChestView.TopText.text = "Locked";
            unlockDurationMinutes = chestController.ChestModel.UnlockDurationMinutes;
            chestController.ChestView.BottomText.text = ( unlockDurationMinutes < 60 ) ? 
                unlockDurationMinutes.ToString( ) + " Min" : ( unlockDurationMinutes / 60 ).ToString( ) + " Hr";

            unlockNowButton.gameObject.SetActive( true );
            setTimerButton.gameObject.SetActive( true );
        }
        public void ChestButtonAction( )
        {
            UIService.Instance.EnableChestPopUp( );
        }
        public void OnStateDisable( )
        {
            unlockNowButton.gameObject.SetActive( false );
            setTimerButton.gameObject.SetActive( false );
        }
        public ChestState GetChestState( )
        {
            return ChestState.LOCKED;
        }
    }
}
