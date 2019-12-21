using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class UserProductReview : BaseModel<string>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Stars { get; set; }

        public string Review { get; set; }

        public string Title { get; set; }
    }
}
