using System;
using HeyCoder.AspNetCore.Mvc.Pager.Interface;
using Microsoft.Extensions.Configuration;

namespace HeyCoder.AspNetCore.Mvc.Pager
{
    public class PagerOption : IPagerOption
    {
        /// <inheritdoc />
        /// <summary>
        /// 数字按钮的个数
        /// </summary>
        public int PageButtonCount { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 当前页码参数名
        /// </summary>
        public string PageIndexParamName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 分页控件div的伪类名
        /// </summary>
        public string PagerClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 分页状态的伪类名
        /// </summary>
        public string PagerStatusClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 当前页页码的伪类名
        /// </summary>
        public string CurrentPageClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 首页按钮伪类名称
        /// </summary>
        public string FirstPageButtonClassName { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 尾页按钮伪类名称
        /// </summary>
        public string LastPageButtonClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 上一组按钮伪类名称
        /// </summary>
        public string PreGroupButtonClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 下一组按钮伪类名称
        /// </summary>
        public string NextGroupButtonClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 上一页按钮伪类名称
        /// </summary>
        public string PrePageButtonClassName { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 下一页按钮伪类名称
        /// </summary>
        public string NextPageButtonClassName { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 页面跳转的文本框伪类名称
        /// </summary>
        public string GotoPageInputClassName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 页面跳转的按钮伪类名称
        /// </summary>
        public string GotoPageButtonClassName { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 页面跳转的按钮伪类名称
        /// </summary>
        public string GotoPageInputId { get; set; }



        /// <inheritdoc />
        /// <summary>
        /// 首页按钮显示文本
        /// </summary>
        public string FirstPageButtonText { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 尾页按钮显示文本
        /// </summary>
        public string LastPageButtonText { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 上一组按钮显示文本
        /// </summary>
        public string PreGroupButtonText { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 下一组按钮显示文本
        /// </summary>
        public string NextGroupButtonText { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 上一页按钮显示文本
        /// </summary>
        public string PrePageButtonText { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 下一页按钮显示文本
        /// </summary>
        public string NextPageButtonText { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 页面跳转的按钮显示文本
        /// </summary>
        public string GotoPageBtuttonText { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 是否显示首页尾页按钮
        /// </summary>
        public bool ShowFirstLastPageButton { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 是否显示上一组下一组按钮按钮
        /// </summary>
        public bool ShowPreNextGroupButton { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 是否显示上一页下一页按钮
        /// </summary>
        public bool ShowPreNextPageButton { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 是否显示分页状态
        /// </summary>
        public bool ShowPagerStatus { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 是否显示数据总数
        /// </summary>
        public bool ShowDataCount { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 是否显示跳转页码区域
        /// </summary>
        public bool ShowGotoPanel { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 每页显示的数据个数
        /// </summary>
        public int PageSize { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 数据总个数
        /// </summary>
        public int DataCount { get; set; }


        /// <inheritdoc />
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 参数名格式化方式
        /// </summary>
        public string ParamNameFormat { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 数据个数显示
        /// </summary>
        public string DataCountTextFormat { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 分页状态显示
        /// </summary>
        public string PagerStatusTextFormat { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 当前页码居中
        /// </summary>
        public bool CurrentPageInCenter { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// MVC路由名字
        /// </summary>
        public string RouteName { get; set; }


        public IConfiguration Configuration { get; }
        public PagerOption(IConfiguration configuration)
        {
            Configuration = configuration;
            CurrentPageInCenter = true;
            ShowPreNextPageButton = true;
            var pagerSection = configuration.GetSection("HeyCoder.MvcPager");
            var propertyArray = GetType().GetProperties();
            foreach (var propertyInfo in propertyArray)
            {
                if (pagerSection.GetSection(propertyInfo.Name) == null) continue;
                var sectionValue = pagerSection.GetSection(propertyInfo.Name).Value;
                if (string.IsNullOrEmpty(sectionValue)) continue;
                var value = Convert.ChangeType(sectionValue, propertyInfo.PropertyType);
                propertyInfo.SetValue(this, value, null);
            }
            if (PageSize <= 0) PageSize = 10;
            if (PageButtonCount <= 0) PageButtonCount = 10;
            if (string.IsNullOrEmpty(PageIndexParamName)) PageIndexParamName = "pageindex";
            if (string.IsNullOrEmpty(PagerClassName)) PagerClassName = "pager";
            if (string.IsNullOrEmpty(PagerStatusClassName)) PagerStatusClassName = "pagerstatus";
            if (string.IsNullOrEmpty(CurrentPageClassName)) CurrentPageClassName = "currentpage";
            if (string.IsNullOrEmpty(FirstPageButtonClassName)) FirstPageButtonClassName = "firstPage";
            if (string.IsNullOrEmpty(LastPageButtonClassName)) LastPageButtonClassName = "lastPage";
            if (string.IsNullOrEmpty(PreGroupButtonClassName)) PreGroupButtonClassName = "pregroup";
            if (string.IsNullOrEmpty(NextGroupButtonClassName)) NextGroupButtonClassName = "nextgroup";
            if (string.IsNullOrEmpty(PrePageButtonClassName)) PrePageButtonClassName = "prepage";
            if (string.IsNullOrEmpty(NextPageButtonClassName)) NextPageButtonClassName = "nextpage";
            if (string.IsNullOrEmpty(GotoPageInputClassName)) GotoPageInputClassName = "txtpage";
            if (string.IsNullOrEmpty(GotoPageButtonClassName)) GotoPageButtonClassName = "btngotopage";
            if (string.IsNullOrEmpty(GotoPageInputId)) GotoPageInputId = "txtpage";
            if (string.IsNullOrEmpty(FirstPageButtonText)) FirstPageButtonText = "首页";
            if (string.IsNullOrEmpty(LastPageButtonText)) LastPageButtonText = "尾页";
            if (string.IsNullOrEmpty(PreGroupButtonText)) PreGroupButtonText = "上一组";
            if (string.IsNullOrEmpty(NextGroupButtonText)) NextGroupButtonText = "下一组";
            if (string.IsNullOrEmpty(PrePageButtonText)) PrePageButtonText = "上一页";
            if (string.IsNullOrEmpty(NextPageButtonText)) NextPageButtonText = "下一页";
            if (string.IsNullOrEmpty(GotoPageBtuttonText)) GotoPageBtuttonText = "跳转";
            if (string.IsNullOrEmpty(ParamNameFormat)) ParamNameFormat = "normal";
            if (string.IsNullOrEmpty(DataCountTextFormat)) DataCountTextFormat = "共{0}条数据";
            if (string.IsNullOrEmpty(PagerStatusTextFormat)) PagerStatusTextFormat = "当前：{0}/{1}";
            if (string.IsNullOrEmpty(RouteName)) RouteName = "default";
        }

        public PagerOption()
        {

            CurrentPageInCenter = true;
            ShowPreNextPageButton = true;
            if (PageSize <= 0) PageSize = 10;
            if (PageButtonCount <= 0) PageButtonCount = 10;
            if (string.IsNullOrEmpty(PageIndexParamName)) PageIndexParamName = "pageindex";
            if (string.IsNullOrEmpty(PagerClassName)) PagerClassName = "pager";
            if (string.IsNullOrEmpty(PagerStatusClassName)) PagerStatusClassName = "pagerstatus";
            if (string.IsNullOrEmpty(CurrentPageClassName)) CurrentPageClassName = "currentpage";
            if (string.IsNullOrEmpty(FirstPageButtonClassName)) FirstPageButtonClassName = "firstPage";
            if (string.IsNullOrEmpty(LastPageButtonClassName)) LastPageButtonClassName = "lastPage";
            if (string.IsNullOrEmpty(PreGroupButtonClassName)) PreGroupButtonClassName = "pregroup";
            if (string.IsNullOrEmpty(NextGroupButtonClassName)) NextGroupButtonClassName = "nextgroup";
            if (string.IsNullOrEmpty(PrePageButtonClassName)) PrePageButtonClassName = "prepage";
            if (string.IsNullOrEmpty(NextPageButtonClassName)) NextPageButtonClassName = "nextpage";
            if (string.IsNullOrEmpty(GotoPageInputClassName)) GotoPageInputClassName = "txtpage";
            if (string.IsNullOrEmpty(GotoPageButtonClassName)) GotoPageButtonClassName = "btngotopage";
            if (string.IsNullOrEmpty(GotoPageInputId)) GotoPageInputId = "txtpage";
            if (string.IsNullOrEmpty(FirstPageButtonText)) FirstPageButtonText = "首页";
            if (string.IsNullOrEmpty(LastPageButtonText)) LastPageButtonText = "尾页";
            if (string.IsNullOrEmpty(PreGroupButtonText)) PreGroupButtonText = "上一组";
            if (string.IsNullOrEmpty(NextGroupButtonText)) NextGroupButtonText = "下一组";
            if (string.IsNullOrEmpty(PrePageButtonText)) PrePageButtonText = "上一页";
            if (string.IsNullOrEmpty(NextPageButtonText)) NextPageButtonText = "下一页";
            if (string.IsNullOrEmpty(GotoPageBtuttonText)) GotoPageBtuttonText = "跳转";
            if (string.IsNullOrEmpty(ParamNameFormat)) ParamNameFormat = "normal";
            if (string.IsNullOrEmpty(DataCountTextFormat)) DataCountTextFormat = "共{0}条数据";
            if (string.IsNullOrEmpty(PagerStatusTextFormat)) PagerStatusTextFormat = "当前：{0}/{1}";
            if (string.IsNullOrEmpty(RouteName)) RouteName = "default";


        }
    }
}
