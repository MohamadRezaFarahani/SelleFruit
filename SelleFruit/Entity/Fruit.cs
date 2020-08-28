using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelleFruit.Entity
{
   public class Fruit
    {
       public int ID
       {
           get;
           set;
       }
       /// <summary>
       /// نوع میوه
       /// </summary>
       public string FruitType
       {
           get;
           set;
       }
       /// <summary>
       /// موجودی فروشندگان
       /// </summary>
       public decimal SellerExist
       {
           get;
           set;
       }
       /// <summary>
       /// موجودی انبار
       /// </summary>
       public decimal StoreExist
       {
           get;
           set;
       }
       /// <summary>
       /// فروخته شده
       /// </summary>
       public decimal Sold
       {
           get;
           set;
       }

    }
}
