using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace code_first.model
{
    public partial class StoreDTO
    {
        [Required]
        public int id{
            set;
            get;
        }
        public string productName{
            set;
            get;
        }

        public DateTime lastPurchased{
            set;
            get;
        }

        public int quantity{
            set;
            get;
        }
        
    }
    
}