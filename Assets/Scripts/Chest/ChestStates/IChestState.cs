namespace ChestSystem
{
    public interface IChestState
    {
        public void OnStateEnable( );

        public void ChestButtonAction( );

        public void OnStateDisable( );

        public ChestState GetChestState( );
    }
}
