using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    class PromotionDAO
    {
        //TODO: need to be checking for null values where corresponding columns are nOT NULL

        public static List<Promotion> GetAllPromotions()
        {
            return DatabaseContext.dbContext.Promotions.ToList();
        }

        public static List<Promotion> GetPromotionsByMake(Make make)
        {
            List<Promotion> promotions = DatabaseContext.dbContext.Promotions.Where(p => p.Make.id == make.id).ToList();
            return promotions;
        }

        public static void RemovePromotion(Promotion promotion)
        {
            DatabaseContext.dbContext.Promotions.Remove(promotion);
            DatabaseContext.dbContext.SaveChangesAsync();
        }

        public static void AddPromotion(Promotion promotion)
        {
            DatabaseContext.dbContext.Promotions.Add(promotion);
            DatabaseContext.dbContext.SaveChangesAsync();
        }

        public static void EditPromotion(Promotion promotion)
        {
            Promotion promotionToUpdate = DatabaseContext.dbContext.Promotions.First(p => p.id == promotion.id);

            DatabaseContext.dbContext.Promotions.Attach(promotionToUpdate);
            promotionToUpdate = promotion;
            DatabaseContext.dbContext.SaveChangesAsync();
        }
    }
}
