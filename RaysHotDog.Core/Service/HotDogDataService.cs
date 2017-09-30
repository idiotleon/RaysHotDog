using System;
using System.Collections.Generic;
using RaysHotDog.Core.Repository;
using RaysHotDog.Core.Model;

namespace RaysHotDog.Core.Service
{
    public class HotDogDataService
    {
        private static HotDogRepository hotDogRepository = new HotDogRepository();

        public HotDogDataService()
        {
        }

        public List<HotDog> GetAllHotDogs(){
            return hotDogRepository.GetAllHotDogs();
        }

        public List<HotDogGroup> GetGroupedHotDogs(){
            return hotDogRepository.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId){
            return hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
        }
    }
}
