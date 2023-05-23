using UnityEngine;
using UnityEngine.UI;
using ChestSystem.Chest;

namespace ChestSystem
{
    public class UIService : MonoSingletonGeneric<UIService>
    {
        [SerializeField] private Button createChestButton;
        [SerializeField] private GameObject rayCastBlocker;
        [SerializeField] private GameObject chestSlotsFullPopUp;
        [SerializeField] private Button closeChestSlotsFull;

        private void Start( )
        {
            rayCastBlocker.SetActive( false );
            chestSlotsFullPopUp.SetActive( false );

            createChestButton.onClick.AddListener( ChestService.Instance.CreateRandomChest );
            closeChestSlotsFull.onClick.AddListener( DisableSlotsFullPop );
        }
        public void EnableSlotsFullPopUp( )
        {
            rayCastBlocker.SetActive( true );
            chestSlotsFullPopUp.SetActive( true );
        }
        private void DisableSlotsFullPop( )
        {
            rayCastBlocker.SetActive( false );
            chestSlotsFullPopUp.SetActive( false );
        }
    }
}
