namespace HeyCoder.AspNetCore.Mvc.Pager.Interface
{
    public interface IPagerOption
    {
        /// <summary>
        /// 数字按钮的个数
        /// </summary>
        int PageButtonCount { get; set; }

        /// <summary>
        /// 当前页码参数名
        /// </summary>
        string PageIndexParamName { get; set; }

        /// <summary>
        /// 分页控件div的伪类名
        /// </summary>
        string PagerClassName { get; set; }

        /// <summary>
        /// 分页状态的伪类名
        /// </summary>
        string PagerStatusClassName { get; set; }

        /// <summary>
        /// 当前页页码的伪类名
        /// </summary>
        string CurrentPageClassName { get; set; }

        /// <summary>
        /// 首页按钮伪类名称
        /// </summary>
        string FirstPageButtonClassName { get; set; }


        /// <summary>
        /// 尾页按钮伪类名称
        /// </summary>
        string LastPageButtonClassName { get; set; }

        /// <summary>
        /// 上一组按钮伪类名称
        /// </summary>
        string PreGroupButtonClassName { get; set; }

        /// <summary>
        /// 下一组按钮伪类名称
        /// </summary>
        string NextGroupButtonClassName { get; set; }

        /// <summary>
        /// 上一页按钮伪类名称
        /// </summary>
        string PrePageButtonClassName { get; set; }


        /// <summary>
        /// 下一页按钮伪类名称
        /// </summary>
        string NextPageButtonClassName { get; set; }


        /// <summary>
        /// 页面跳转的文本框伪类名称
        /// </summary>
        string GotoPageInputClassName { get; set; }

        /// <summary>
        /// 页面跳转的按钮伪类名称
        /// </summary>
        string GotoPageButtonClassName { get; set; }


        /// <summary>
        /// 页面跳转的按钮伪类名称
        /// </summary>
        string GotoPageInputId { get; set; }



        /// <summary>
        /// 首页按钮显示文本
        /// </summary>
        string FirstPageButtonText { get; set; }

        /// <summary>
        /// 尾页按钮显示文本
        /// </summary>
        string LastPageButtonText { get; set; }

        /// <summary>
        /// 上一组按钮显示文本
        /// </summary>
        string PreGroupButtonText { get; set; }

        /// <summary>
        /// 下一组按钮显示文本
        /// </summary>
        string NextGroupButtonText { get; set; }


        /// <summary>
        /// 上一页按钮显示文本
        /// </summary>
        string PrePageButtonText { get; set; }


        /// <summary>
        /// 下一页按钮显示文本
        /// </summary>
        string NextPageButtonText { get; set; }

        /// <summary>
        /// 页面跳转的按钮显示文本
        /// </summary>
        string GotoPageBtuttonText { get; set; }

        /// <summary>
        /// 是否显示首页尾页按钮
        /// </summary>
        bool ShowFirstLastPageButton { get; set; }

        /// <summary>
        /// 是否显示上一组下一组按钮按钮
        /// </summary>
        bool ShowPreNextGroupButton { get; set; }


        /// <summary>
        /// 是否显示上一页下一页按钮
        /// </summary>
        bool ShowPreNextPageButton { get; set; }


        /// <summary>
        /// 是否显示分页状态
        /// </summary>
        bool ShowPagerStatus { get; set; }

        /// <summary>
        /// 是否显示数据总数
        /// </summary>
        bool ShowDataCount { get; set; }

        /// <summary>
        /// 是否显示跳转页码区域
        /// </summary>
        bool ShowGotoPanel { get; set; }


        /// <summary>
        /// 每页显示的数据个数
        /// </summary>
        int PageSize { get; set; }


        /// <summary>
        /// 数据总个数
        /// </summary>
        int DataCount { get; set; }


        /// <summary>
        /// 当前页码
        /// </summary>
        int PageIndex { get; set; }

        /// <summary>
        /// 参数名格式化方式
        /// </summary>
        string ParamNameFormat { get; set; }

        /// <summary>
        /// 数据个数显示
        /// </summary>
        string DataCountTextFormat { get; set; }

        /// <summary>
        /// 分页状态显示
        /// </summary>
        string PagerStatusTextFormat { get; set; }

        /// <summary>
        /// 当前页码居中
        /// </summary>
        bool CurrentPageInCenter { get; set; }

        /// <summary>
        /// MVC路由名字
        /// </summary>
        string RouteName { get; set; }
    }
}
