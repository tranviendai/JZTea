using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JZTea.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Text;
using System.Security.Cryptography;

namespace JZTea.Data
{
    public class JZTeaContext : DbContext
    {
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var hasher = new PasswordHasher<User>();
            builder.Entity<User>(entity =>
            {

                var sha = SHA256.Create();
                var asByteArr = Encoding.Default.GetBytes("a"); //pass "a"
                var hash = sha.ComputeHash(asByteArr);

                entity.HasData(
                    new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        FullName = "Tran Vien Dai",
                        Email = "tranviendai@gmail.com",
                        Image = "https://www.nicepng.com/png/full/128-1280406_view-user-icon-png-user-circle-icon-png.png",
                        UserName = "a",
                        PhoneNumber = "0582072743",
                        PasswordHash = Convert.ToBase64String(hash),
                        DateCreated = DateTime.Now,
                        IsActive= true,
                        Role = "ADMIN"
                    });
                entity.ToTable("User");
            });
            builder.Entity<Category>(entity =>
            {
                entity.HasData(
                    new Category
                    {
                        id = "milk tea",
                        name = "Milk Tea",
                        icon = "ic01.png"
                    },
                     new Category
                     {
                         id = "cream",
                         name = "Cream",
                         icon = "ic02.png"
                     },
                      new Category
                      {
                          id = "juice",
                          name = "Juice",
                          icon = "ic03.png"
                      },
                       new Category
                       {
                           id = "ice drink",
                           name = "Ice Drink",
                           icon = "ic04.png"
                       }
                     );
            });
            builder.Entity<Topping>(entity =>
            {
                entity.HasData(
                    new Topping
                    {
                        id = 1,
                        name = "Brown Jelly",
                        image = "tp01.png",
                        price = 0.5
                    },
                    new Topping
                    {
                        id = 2,
                        name = "Coffee Jelly",
                        image = "tp02.png",
                        price = 0.5
                    },
                    new Topping
                    {
                        id = 3,
                        name = "Fabric Pearl",
                        image = "tp03.png",
                        price = 0.5
                    },
                    new Topping
                    {
                        id = 4,
                        name = "Mango Pearl",
                        image = "tp04.png",
                        price = 0.5
                    },
                     new Topping
                     {
                         id = 5,
                         name = "Vera",
                         image = "tp05.png",
                         price = 0.5
                     },
                        new Topping
                        {
                            id = 6,
                            name = "Black Pearl",
                            image = "tp06.png",
                            price = 0.5
                        },
                        new Topping
                        {
                            id = 7,
                            name = "White Pearl",
                            image = "tp07.png",
                            price = 0.5
                        },
                         new Topping
                         {
                             id = 8,
                             name = "Jelly fruit",
                             image = "tp08.png",
                             price = 0.5
                         },
                          new Topping
                          {
                              id = 9,
                              name = "Pudding",
                              image = "tp09.png",
                              price = 0.5
                          }
                     );
            });
            builder.Entity<Product>(entity =>
            {
                entity.HasData(
                    new Product
                    {
                        id = 1,
                        name = "Okinawa Coffee Milk Tea",
                        image = "sp1.png",
                        price = 2.21,
                        discount = 11,
                        postDate = DateTime.Now,
                        description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                        isPublish = true,
                        categoryID = "milk tea",
                    },
                    new Product
                    {
                        id = 2,
                        name = "Okinawa Oreo Cream Milk Tea",
                        image = "sp2.png",
                        price = 2.21,
                        discount = 15,
                        postDate = DateTime.Now,
                        description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                        isPublish = true,
                        categoryID = "milk tea",
                    },
                  new Product
                  {
                      id = 3,
                      name = "Black Pearl Mango Milk Tea",
                      image = "sp3.png",
                      price = 2.21,
                      discount = 10,
                      postDate = DateTime.Now,
                      description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                      isPublish = true,
                      categoryID = "milk tea",
                  },
                       new Product
                       {
                           id = 4,
                           name = "Okinawa Milk Tea",
                           image = "sp4.png",
                           price = 2.21,
                           discount = 12,
                           postDate = DateTime.Now,
                           description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                           isPublish = true,
                           categoryID = "milk tea",
                       },
                          new Product
                          {
                              id = 5,
                              name = "Matcha Red Bean Milk Tea",
                              image = "sp5.png",
                              price = 2.21,
                              postDate = DateTime.Now,
                              discount = 10,
                              description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                              isPublish = true,
                              categoryID = "milk tea",
                          },
                           new Product
                           {
                               id = 6,
                               name = "Oolong Milk Tea 3J",
                               image = "sp6.png",
                               price = 2.21,
                               discount = 15,
                               postDate = DateTime.Now,
                               description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                               isPublish = true,
                               categoryID = "milk tea",
                           },
                            new Product
                            {
                                id = 7,
                                name = "Red Bean Pudding Milk Tea",
                                image = "sp7.png",
                                price = 2.21,
                                discount = 15,
                                postDate = DateTime.Now,
                                description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                                isPublish = true,
                                categoryID = "milk tea",
                            },
                             new Product
                             {
                                 id = 8,
                                 name = "Milk Tea & Black Pearl Ice Cream",
                                 image = "sp8.png",
                                 price = 1.48,
                                 discount = 0,
                                 postDate = DateTime.Now,
                                 description = "Produced from high quality ingredients in Vietnam and the ice cream recipe is carefully researched according to Vietnamese taste",
                                 isPublish = true,
                                 categoryID = "cream",
                             },
                              new Product
                              {
                                  id = 9,
                                  name = "Milk Tea Ice Cream",
                                  image = "sp9.png",
                                  price = 1.48,
                                  discount = 0,
                                  postDate = DateTime.Now,
                                  description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                                  isPublish = true,
                                  categoryID = "cream",
                              },
                                 new Product
                                 {
                                     id = 10,
                                     name = "Alisan Fruit Tea",
                                     image = "sp10.png",
                                     price = 1.8,
                                     discount = 5,
                                     postDate = DateTime.Now,
                                     description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                                     isPublish = true,
                                     categoryID = "juice",
                                 },
                                  new Product
                                  {
                                      id = 11,
                                      name = "Ai-yu Lemon and White Pearl",
                                      image = "sp11.png",
                                      price = 1.8,
                                      discount = 5,
                                      postDate = DateTime.Now,
                                      description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                                      isPublish = true,
                                      categoryID = "juice",
                                  },
                                   new Product
                                   {
                                       id = 12,
                                       name = "Pink Peach Plum Seeds",
                                       image = "sp12.png",
                                       price = 1.8,
                                       discount = 5,
                                       postDate = DateTime.Now,
                                       description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                                       isPublish = true,
                                       categoryID = "juice",
                                   },
                                      new Product
                                      {
                                          id = 13,
                                          name = "Pink Peach Plum Seeds",
                                          image = "sp13.png",
                                          price = 1.8,
                                          discount = 5,
                                          postDate = DateTime.Now,
                                          description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                                          isPublish = true,
                                          categoryID = "juice",
                                      },
                                       new Product
                                       {
                                           id = 14,
                                           name = "Golden Milk Peaches Ice Snow",
                                           image = "sp14.png",
                                           price = 2.11,
                                           discount = 8,
                                           postDate = DateTime.Now,
                                           description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                           isPublish = true,
                                           categoryID = "ice drink",
                                       },
                                         new Product
                                         {
                                             id = 15,
                                             name = "Pink Peach Ice Snow",
                                             image = "sp15.png",
                                             price = 2.11,
                                             discount = 8,
                                             postDate = DateTime.Now,
                                             description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                             isPublish = true,
                                             categoryID = "ice drink",
                                         },
                                           new Product
                                           {
                                               id = 16,
                                               name = "Strawberry Choco Cookie Smoothie",
                                               image = "sp16.png",
                                               price = 2.11,
                                               discount = 8,
                                               postDate = DateTime.Now,
                                               description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                               isPublish = true,
                                               categoryID = "ice drink",
                                           },
                                             new Product
                                             {
                                                 id = 17,
                                                 name = "Mint Cookie Smoothie",
                                                 image = "sp17.png",
                                                 price = 2.11,
                                                 discount = 8,
                                                 postDate = DateTime.Now,
                                                 description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                                 isPublish = true,
                                                 categoryID = "ice drink",
                                             },
                                               new Product
                                               {
                                                   id = 18,
                                                   name = "Strawberry Oreo Smoothie",
                                                   image = "sp18.png",
                                                   price = 2.11,
                                                   discount = 8,
                                                   postDate = DateTime.Now,
                                                   description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                                   isPublish = true,
                                                   categoryID = "ice drink",
                                               },
                                                 new Product
                                                 {
                                                     id = 19,
                                                     name = "Iced Matcha",
                                                     image = "sp19.png",
                                                     price = 2.11,
                                                     discount = 8,
                                                     postDate = DateTime.Now,
                                                     description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                                     isPublish = true,
                                                     categoryID = "ice drink",
                                                 },
                                                 new Product
                                                 {
                                                     id = 20,
                                                     name = "Yakult Peach Crushed Stone",
                                                     image = "sp20.png",
                                                     price = 2.11,
                                                     discount = 8,
                                                     postDate = DateTime.Now,
                                                     description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                                                     isPublish = true,
                                                     categoryID = "ice drink",
                                                 }
                    );
            });
        }
        public JZTeaContext(DbContextOptions<JZTeaContext> options)
    : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
        public DbSet<Topping> Topping { get; set; }
        public DbSet<User> User { get; set; }
    }
}
