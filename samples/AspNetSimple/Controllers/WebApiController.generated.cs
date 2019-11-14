// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using R4Mvc;
using AspNetSimple;

namespace AspNetSimple.Controllers
{
    public partial class WebApiController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public WebApiController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected WebApiController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPage(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPage(Task<IActionResult> taskResult)
        {
            return RedirectToPage(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPagePermanent(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPagePermanent(Task<IActionResult> taskResult)
        {
            return RedirectToPagePermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ApiCallWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult TaskApiCallWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ApiCallTypedWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallTypedWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult TaskApiCallTypedWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallTypedWithParams);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public WebApiController Actions => MVC.WebApi;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "WebApi";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "WebApi";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string ApiCall = "ApiCall";
            public readonly string ApiCallWithParams = "ApiCallWithParams";
            public readonly string TaskApiCall = "TaskApiCall";
            public readonly string TaskApiCallWithParams = "TaskApiCallWithParams";
            public readonly string ApiCallTyped = "ApiCallTyped";
            public readonly string ApiCallTypedWithParams = "ApiCallTypedWithParams";
            public readonly string TaskApiCallTyped = "TaskApiCallTyped";
            public readonly string TaskApiCallTypedWithParams = "TaskApiCallTypedWithParams";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string ApiCall = "ApiCall";
            public const string ApiCallWithParams = "ApiCallWithParams";
            public const string TaskApiCall = "TaskApiCall";
            public const string TaskApiCallWithParams = "TaskApiCallWithParams";
            public const string ApiCallTyped = "ApiCallTyped";
            public const string ApiCallTypedWithParams = "ApiCallTypedWithParams";
            public const string TaskApiCallTyped = "TaskApiCallTyped";
            public const string TaskApiCallTypedWithParams = "TaskApiCallTypedWithParams";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionParamsClass_ApiCallWithParams s_ApiCallWithParamsParams = new ActionParamsClass_ApiCallWithParams();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionParamsClass_ApiCallWithParams ApiCallWithParamsParams => s_ApiCallWithParamsParams;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ApiCallWithParams
        {
            public readonly string id = "id";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionParamsClass_TaskApiCallWithParams s_TaskApiCallWithParamsParams = new ActionParamsClass_TaskApiCallWithParams();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionParamsClass_TaskApiCallWithParams TaskApiCallWithParamsParams => s_TaskApiCallWithParamsParams;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TaskApiCallWithParams
        {
            public readonly string id = "id";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionParamsClass_ApiCallTypedWithParams s_ApiCallTypedWithParamsParams = new ActionParamsClass_ApiCallTypedWithParams();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionParamsClass_ApiCallTypedWithParams ApiCallTypedWithParamsParams => s_ApiCallTypedWithParamsParams;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ApiCallTypedWithParams
        {
            public readonly string id = "id";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionParamsClass_TaskApiCallTypedWithParams s_TaskApiCallTypedWithParamsParams = new ActionParamsClass_TaskApiCallTypedWithParams();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionParamsClass_TaskApiCallTypedWithParams TaskApiCallTypedWithParamsParams => s_TaskApiCallTypedWithParamsParams;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TaskApiCallTypedWithParams
        {
            public readonly string id = "id";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
            }
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_WebApiController : AspNetSimple.Controllers.WebApiController
    {
        public R4MVC_WebApiController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void ApiCallTypedOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product> ApiCallTyped()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallTyped);
            ApiCallTypedOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ApiCallTypedWithParamsOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product> ApiCallTypedWithParams(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallTypedWithParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ApiCallTypedWithParamsOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void TaskApiCallTypedOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>> TaskApiCallTyped()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallTyped);
            TaskApiCallTypedOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>>(callInfo);
        }

        [NonAction]
        partial void TaskApiCallTypedWithParamsOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>> TaskApiCallTypedWithParams(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallTypedWithParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            TaskApiCallTypedWithParamsOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>>(callInfo);
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
