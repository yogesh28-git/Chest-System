using UnityEngine;

namespace ChestSystem.Chest
{
    public class ChestView : MonoBehaviour
    {
        private ChestController chestController;
        public void SetController( ChestController controller )
        {
            this.chestController = controller;
        }
    }

}
