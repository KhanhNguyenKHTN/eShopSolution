﻿using eShop.ViewModel.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Systems.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}