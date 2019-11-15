using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class SupportMessage : BaseModel<string>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
