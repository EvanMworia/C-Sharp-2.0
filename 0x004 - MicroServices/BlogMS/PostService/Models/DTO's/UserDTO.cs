namespace PostService.Models.DTO_s
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;
    }
}
 //NOT ENTIRELY SURE IF THIS DTO SHOULD EVEN BE HERE, BORROWED FROM AUTH TO TRACK POSTS ASSOCIATED WITH their RESPECTIVE USER DETAILS