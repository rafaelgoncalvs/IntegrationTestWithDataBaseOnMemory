﻿using AutomatedTestingInCSharp.Domain;
using FluentNHibernate.Mapping;

namespace AutomatedTestingInCSharp.Infra
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(user => user.Id);
            Map(user => user.Name);
            Map(user => user.Email);
            HasMany(user => user.Teams).Cascade.AllDeleteOrphan();
        }
    }
}