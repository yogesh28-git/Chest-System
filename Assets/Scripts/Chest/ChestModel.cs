using UnityEngine;

namespace ChestSystem.Chest
{
    public class ChestModel
    {
        private ChestController chestController;
        private ChestScriptableObject chestObject;
        public ChestModel( ChestScriptableObject chestObject)
        {
            this.chestObject = chestObject;
        }
        public void SetController(ChestController controller )
        {
            this.chestController = controller;
        }
    }
}
