using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using ABP.TBK.TaoBaoKe.Products;

namespace ABP.TBK.TaoBaoKe.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductEditDto
    {
        public int? Id { get; set; }

        /// <summary>
         /// 商品ID
         /// </summary>
        public string PId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>

        public string ProductName { get; set; }
        /// <summary>
        /// 商品主图
        /// </summary>
        public string Img { get; set; }
        /// <summary>
        /// 商品链接
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 淘宝客地址
        /// </summary>
        public string TBKURL { get; set; }
        /// <summary>
        /// 单价
        /// </summary> 
        public decimal Price { get; set; }
        /// <summary>
        /// 商品月销量
        /// </summary> 
        public int Sales { get; set; }
        /// <summary>
        /// 收入比率(%)
        /// </summary>
        public decimal IncomeRatio { get; set; }
        /// <summary>
        /// 佣金
        /// </summary>
        public decimal Brokerage { get; set; }
        /// <summary>
        /// 旺旺
        /// </summary>
        public string WW { get; set; }
        /// <summary>
        /// 旺旺
        /// </summary>
        public string WWID { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string MallName { get; set; }
        /// <summary>
        /// 平台类型
        /// </summary>
        public string Platform { get; set; }
        /// <summary>
        /// 优惠券ID
        /// </summary>
        public string CouponID { get; set; }
        /// <summary>
        /// 优惠券总量
        /// </summary>
        public int CouponCount { get; set; }
        /// <summary>
        /// 优惠券剩余
        /// </summary>
        public int CouponRemaining { get; set; }
        /// <summary>
        /// 优惠券面额
        /// </summary>
        public string CouponDesc { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public DateTime CouponBeginDate { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public DateTime CouponEndDate { get; set; }
        /// <summary>
        ///优惠券链接
        /// </summary>
        public string CouponUrl { get; set; }
        /// <summary>
        ///优惠券推广链接
        /// </summary>
        public string CouponTGUrl { get; set; }
    }
}
