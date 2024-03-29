﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.DemoApp.Core.Application.ViewModels.SeedWork;
using WEMBLEY.DemoApp.Core.Domain.Dtos.References;

namespace WEMBLEY.DemoApp.Core.Application.Store
{
    public class HomeDataStore : BaseViewModel
    {
        public List<ParameterDto> HomeDatas { get; private set; }
        public HomeDataStore()
        {
            HomeDatas = new();
        }

        public void SetHomeRef(IEnumerable<ParameterDto> dtos)
        {
            HomeDatas = dtos.ToList();
        }

    }
}
