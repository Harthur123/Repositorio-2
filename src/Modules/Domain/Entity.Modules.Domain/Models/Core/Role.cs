﻿using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Modules.Domain.Models.Core
{
    public class Role : Entity, IAggregateRoot
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();

        public Guid UserRoleId { get; private set; }

        public UserRole UserRole { get; private set; }
    }
}