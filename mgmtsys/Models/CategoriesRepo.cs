﻿using System.Security.Cryptography.X509Certificates;

namespace mgmtsys.Models
{
    public class CategoriesRepo
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category{ CategoryId = 1, Name = "Tea", Description = "Beverage"},
            new Category{ CategoryId = 2, Name = "Cake", Description = "Bakery"}

        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        } 
        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description,
                };
            }
            return null;
        }
        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;

            var categoryToUpdate = GetCategoryById(categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;

            }

        }


         public static void DeleteCategory(int categoryId)
            {

                var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
                if (category != null)
                {
                    _categories.Remove(category);
                }
            }
        


    }
}
