namespace Chapter.State
{
    public interface IBikeState 
    {
        void Handle(BikeController controller); // pass an instance of BikeController in the Handle() method
    }                                           // permits state classes to access public properties of BikeController
}