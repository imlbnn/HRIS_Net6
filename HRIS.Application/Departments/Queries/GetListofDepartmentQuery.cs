﻿using HRIS.Application.Common.Mappings;
using HRIS.Application.Departments.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.Departments.Queries
{
    public class GetListofDepartmentQuery : IRequest<IEnumerable<GetDepartmentDto>>
    {
    }
}
