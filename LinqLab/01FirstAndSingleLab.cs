﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample FirstToGetUserNameEqualToDemo()
        {
            return Source.First(x => x.UserName.Equals("demo"));
        }

        public Sample FirstOrDefaultToGetUserNameEuqalToSkilltree()
        {
            return Source.FirstOrDefault(x => x.UserName.Equals("skilltree"));
        }

        public Sample FirstToGetUserNameEuqalToSkilltree()
        {
            return Source.First(x => x.UserName.Equals("skilltree"));
        }

        public Sample SingleToGetUserNameEuqalToDemo()
        {
            return Source.Single(x => x.UserName.Equals("demo"));
        }

        public Sample SingleToGetUserNameEuqalToBill()
        {
            return Source.Single(x => x.Equals("bill"));
        }
        public Sample SingleOrDefaultToGetUserNameEuqalToBill()
        {
            return Source.SingleOrDefault(x => x.UserName.Equals("bill"));
        }

        public Sample SingleOrDefaultToGetUserNameEuqalToSkillTree()
        {
            return Source.SingleOrDefault(x => x.UserName.Equals("skilltree"));
        }
    }
}
