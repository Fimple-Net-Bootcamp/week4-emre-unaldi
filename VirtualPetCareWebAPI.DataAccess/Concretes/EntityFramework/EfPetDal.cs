﻿using VirtualPetCareWebAPI.DataAccess.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Entities;

namespace VirtualPetCareWebAPI.DataAccess.Concretes.EntityFramework
{
    public class EfPetDal : EfEntityRepositoryBase<Pet, PetCareDbContext>, IPetDal
    {

    }
}
