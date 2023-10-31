using System;
using System.ComponentModel.DataAnnotations;

namespace Car_CRUD.Models
{
    public class Car
    {
        public int Id { get; set; } // 流水號

        [Display(Name ="廠牌")]
        [Required]
        public string Brand { get; set; } // 廠牌

        [Display(Name ="廠牌")]
        [Required]
        public string Model { get; set; } // 廠牌

        [Display(Name ="車牌號碼")]
        public string CarNum { get; set; } // 車牌號碼 (ABC-1234)

        [Display(Name ="車色")]
        public string Color { get; set; } // 車色

        [Display(Name ="年份")]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; } // 年份 (yyyy-mm)

        [Display(Name ="結構評價")]
        public int SE { get; set; } // 結構評價

        [Display(Name ="內裝評價")]
        public int IE { get; set; } // 內裝評價
    }
}
