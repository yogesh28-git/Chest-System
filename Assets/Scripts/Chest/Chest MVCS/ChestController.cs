using UnityEngine;

namespace ChestSystem.Chest
{
    public class ChestController
    {
        public ChestModel ChestModel { get; private set; }
        public ChestView ChestView { get; private set; }
        public ChestController( ChestModel chestModel, ChestView chestPrefab )
        {
            this.ChestModel = chestModel;
            this.ChestView = GameObject.Instantiate<ChestView>( chestPrefab );

            ChestModel.SetController( this );
            ChestView.SetController( this );
        }
    }
}
