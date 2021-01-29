using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    { //snippet-hazır kodlar
        public int Id { get;set; } //değişkenin benzerszözelliği
        public string ProductName { get; set; } //ürününadı
        public int UnitPrice { get; set; }  //ürününfiyatı
        public int CategoryId { get; set; }  //ürünün benzersizkategorisi
        public int UnitInStock { get; set; }  //ürününstokadedi
         
    }
}
