﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System;

namespace Demo.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int MobileId { get; set; }  //FK : liên kết sang PK của bảng Mobile

        //Order - Mobile: Many To One
        public Book Book { get; set; }  //dùng để truy xuất các thông tin của bảng Mobile

        public string UserEmail { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public double OrderPrice { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
    }
}
