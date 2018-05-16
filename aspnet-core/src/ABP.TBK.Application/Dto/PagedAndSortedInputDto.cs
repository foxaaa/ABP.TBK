using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
namespace ABP.TBK.Dto
{
    public class PagedAndSortedInputDto : IPagedAndSortedResultRequest, ISortedResultRequest
    {
        public string Sorting { get; set; }
        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }
        [Range(1,50)]
        public int MaxResultCount { get; set; }

        public PagedAndSortedInputDto() { 
            this.SkipCount = 0;
            this.MaxResultCount = 50;
        }
    }
}
