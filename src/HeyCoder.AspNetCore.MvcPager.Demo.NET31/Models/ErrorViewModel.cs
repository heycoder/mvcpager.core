using System;

namespace HeyCoder.AspNetCore.MvcPager.Demo.NET31.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
