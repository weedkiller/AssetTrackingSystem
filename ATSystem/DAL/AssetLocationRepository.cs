﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ATSystem.Context;
using ATSystem.DAL.BaseRepository;
using ATSystem.Models.Entity;
using ATSystem.Models.Interface.DAL;

namespace ATSystem.DAL
{
    public class AssetLocationRepository:BaseRepository<AssetLocation>,IAssetLocationRepository
    {
        public AssetLocationRepository(DbContext db) : base(new AssetDbContext())
        {
            base._db = db;
        }

        public AssetDbContext Context {
            get { return _db as AssetDbContext; }
        }


        public bool IsExist(string shortname)
        {
            bool IsExist = Context.AssetLocation.Any(c => c.ShortName == shortname);
            return IsExist;
        }
    }
}