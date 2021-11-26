﻿/*
*
* 文件名    ：ConsumptionService                             
* 程序说明  : 用户组服务
* 更新时间  : 2020-09-11 09：46 
*/

namespace Consumption.Service
{
    using Consumption.Core.Request;
    using Consumption.Shared.Dto;
    using Consumption.Shared.HttpContact;
    using Consumption.ViewModel.Interfaces;
    using RestSharp;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// 用户组服务
    /// </summary>
    public partial class GroupService : BaseService<GroupDto>, IGroupRepository
    {
        public async Task<BaseResponse<List<MenuModuleGroupDto>>> GetMenuModuleListAsync()
        {
            return await new BaseServiceRequest().GetRequest<BaseResponse<List<MenuModuleGroupDto>>>(new GroupModuleRequest(), Method.GET);
        }

        public async Task<BaseResponse<GroupDataDto>> GetGroupAsync(int id)
        {
            return await new BaseServiceRequest().GetRequest<BaseResponse<GroupDataDto>>(new GroupInfoRequest() { id = id }, Method.GET);
        }

        public async Task<BaseResponse> SaveGroupAsync(GroupDataDto group)
        {
            var r = await new BaseServiceRequest().GetRequest<BaseResponse>(new GroupSaveRequest()
            { groupDto = group }, Method.POST);
            return r;
        }
    }


}
