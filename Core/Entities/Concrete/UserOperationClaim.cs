namespace Core.Entities.Concrete
{
    public partial class OperationClaim
    {
        class UserOperationClaim :IEntity
        {
            public int Id { get; set; }
            public int OperationClaimId { get; set; }
            public int UserId { get; set; }
        }
    }
}
