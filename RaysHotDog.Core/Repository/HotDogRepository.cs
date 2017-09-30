using System;
using System.Collections.Generic;
using RaysHotDog.Core.Model;
using System.Linq;

namespace RaysHotDog.Core.Repository
{
    public class HotDogRepository
    {
        public HotDogRepository()
        {
        }

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs = from hotDogGroup in hotDogGroups
                                          from hotDog in hotDogGroup.HotDogs
                                          select hotDog;
            return hotDogs.ToList<HotDog>();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            IEnumerable<HotDog> hotDogs = from hotDogGroup in hotDogGroups
                                          from hotDog in hotDogGroup.HotDogs
                                          where hotDog.HotDogId == hotDogId
                                          select hotDog;
            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs(){
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId){
            var group = hotDogGroups.Where(h => h.HotDogGroupId == hotDogGroupId).FirstOrDefault();

            if(group != null){
                return group.HotDogs;
            }

            return null;
        }

        public List<HotDog> GetFavoriteHotDogs(){
            IEnumerable<HotDog> hotDogs = from hotDogGroup in hotDogGroups
                                          from hotDog in hotDogGroup.HotDogs
                                          where hotDog.IsFavorite
                                          select hotDog;

            return hotDogs.ToList<HotDog>();
        }

        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup(){
                HotDogGroupId = 1,
                Title = "Meat lovers",
                ImagePath="",
                HotDogs = new List<HotDog>(){
                    new HotDog(){
                        HotDogId = 1,
                        Name = "Regular Hot Dog",
                        ShortDescription = "The best there is on this planet",
                        Description = "Manchego smelly cheese danish fontina. Hard cheese cc",
                        ImagePath = "hotdog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>(){
                            "Regular bun", "Sausage", "Ketchup"
                        },
                        Price = 8,
                        IsFavorite = false},
                    new HotDog()
                    {
                        HotDogId = 2,
                        Name = "Haute Dog",
                        ShortDescription = "The classy one",
                        Description = "Bacon blah blah",
                        ImagePath = "hotdog2",
                        Available = true,
                        PrepTime = 15,
                        Ingredients = new List<string>(){
                            "Baked bun", "Gourmet sausage", "F"
                        },
                        Price = 10,
                        IsFavorite = false
                    },
                    new HotDog()
                    {
                        HotDogId = 3,
                        Name = "Extra long",
                        ShortDescription = "For when a regular one isn't enough",
                        Description = "Capicola short login should strip streak ribeye pork",
                        ImagePath = "hotdog3",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>(){
                            "Extra long bun", "Extra long sausage", "F"
                        },
                        Price = 8,
                        IsFavorite = true
                    }
                }
            },
            new HotDogGroup(){
                HotDogGroupId = 2,
                Title = "Veggie lovers",
                ImagePath ="",
                HotDogs = new List<HotDog>(){
                    new HotDog(){
                        HotDogId = 4,
                        Name = "Veggie Hot Dog",
                        ShortDescription = "American for non-meat-lovers",
                        Description = "Veggies es bonus vobis, prinde vos postulo essum mac",
                        ImagePath = "hotdog4",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>(){
                            "Extra long bun", "Extra long sausage", "F"
                        },
                        Price = 8,
                        IsFavorite = true
                    }
                }
            }
        };
    }
}
