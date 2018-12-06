namespace Kaczorek.BL
{
    public abstract class BaseClass
    {
        public bool IsNew { get; set; }
        public bool HaveChanges { get; set; }
        public ObjectStateOptions ObjectState { get; set; }
        public bool DataValid
        {
            get
            {
                return Validate();
            }
        }
        public abstract bool Validate();
    }

    public enum ObjectStateOptions
    {
        Active,
        Deleted
    }
}