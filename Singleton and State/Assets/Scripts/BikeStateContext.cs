namespace Chapter.State
{
    public class BikeStateContext  // class exposes a public property that points to the current state of the bike; it's aware of any state change
    {                             
        public IBikeState CurrentState
        {
            get;
            set;
        }

        private readonly BikeController _bikeController;

        public BikeStateContext(BikeController _bikeController)
        {
            _bikeController = bikeController;
        }

        public void Transition()  // update current state through its property & transition
        {
            CurrentState.Handle(_bikeController);
        }

        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }
    }
}
