using Abp;
using ABP.TBK.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Runtime.Validation;

namespace ABP.TBK.TaoBaoKe.Dto
{
    public class GetProductInput : PagedAndSortedInputDto, IShouldNormalize
    {

        public string FilterText { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting)) {
                Sorting = "Id";
            }
        }
    }
}
