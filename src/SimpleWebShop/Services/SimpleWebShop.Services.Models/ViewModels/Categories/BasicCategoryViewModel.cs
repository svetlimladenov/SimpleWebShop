using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Services.Models.ViewModels.Categories
{
    public class BasicCategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }

        private string nameForLink;

        public string NameForLink
        {
            get
            {
                var splitedName = this.Name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var result = string.Join("-", splitedName);
                return result;
            }
            private set { this.nameForLink = value; }
        }
    }
}
