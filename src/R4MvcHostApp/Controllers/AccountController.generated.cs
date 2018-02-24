// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

namespace R4MvcHostApp.Controllers
{
    public partial class AccountController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected AccountController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
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
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Login()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Login);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Register()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Register);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalLogin()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLogin);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalLoginCallback()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLoginCallback);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalLoginConfirmation()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLoginConfirmation);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ConfirmEmail()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ConfirmEmail);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ResetPassword()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult SendCode()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.SendCode);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult VerifyCode()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.VerifyCode);
        }

        [GeneratedCode("R4Mvc", "1.0")]
        public AccountController Actions => MVC.Account;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Account";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Account";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Login = "Login";
            public readonly string Register = "Register";
            public readonly string Logout = "Logout";
            public readonly string ExternalLogin = "ExternalLogin";
            public readonly string ExternalLoginCallback = "ExternalLoginCallback";
            public readonly string ExternalLoginConfirmation = "ExternalLoginConfirmation";
            public readonly string ConfirmEmail = "ConfirmEmail";
            public readonly string ForgotPassword = "ForgotPassword";
            public readonly string ForgotPasswordConfirmation = "ForgotPasswordConfirmation";
            public readonly string ResetPassword = "ResetPassword";
            public readonly string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            public readonly string SendCode = "SendCode";
            public readonly string VerifyCode = "VerifyCode";
            public readonly string AccessDenied = "AccessDenied";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Login = "Login";
            public const string Register = "Register";
            public const string Logout = "Logout";
            public const string ExternalLogin = "ExternalLogin";
            public const string ExternalLoginCallback = "ExternalLoginCallback";
            public const string ExternalLoginConfirmation = "ExternalLoginConfirmation";
            public const string ConfirmEmail = "ConfirmEmail";
            public const string ForgotPassword = "ForgotPassword";
            public const string ForgotPasswordConfirmation = "ForgotPasswordConfirmation";
            public const string ResetPassword = "ResetPassword";
            public const string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            public const string SendCode = "SendCode";
            public const string VerifyCode = "VerifyCode";
            public const string AccessDenied = "AccessDenied";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            [GeneratedCode("R4Mvc", "1.0")]
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            [GeneratedCode("R4Mvc", "1.0")]
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string AccessDenied = "AccessDenied";
                public readonly string ConfirmEmail = "ConfirmEmail";
                public readonly string ExternalLoginConfirmation = "ExternalLoginConfirmation";
                public readonly string ExternalLoginFailure = "ExternalLoginFailure";
                public readonly string ForgotPassword = "ForgotPassword";
                public readonly string ForgotPasswordConfirmation = "ForgotPasswordConfirmation";
                public readonly string Lockout = "Lockout";
                public readonly string Login = "Login";
                public readonly string Register = "Register";
                public readonly string ResetPassword = "ResetPassword";
                public readonly string ResetPasswordConfirmation = "ResetPasswordConfirmation";
                public readonly string SendCode = "SendCode";
                public readonly string VerifyCode = "VerifyCode";
            }

            public string AccessDenied = "~/Views/Account/AccessDenied.cshtml";
            public string ConfirmEmail = "~/Views/Account/ConfirmEmail.cshtml";
            public string ExternalLoginConfirmation = "~/Views/Account/ExternalLoginConfirmation.cshtml";
            public string ExternalLoginFailure = "~/Views/Account/ExternalLoginFailure.cshtml";
            public string ForgotPassword = "~/Views/Account/ForgotPassword.cshtml";
            public string ForgotPasswordConfirmation = "~/Views/Account/ForgotPasswordConfirmation.cshtml";
            public string Lockout = "~/Views/Account/Lockout.cshtml";
            public string Login = "~/Views/Account/Login.cshtml";
            public string Register = "~/Views/Account/Register.cshtml";
            public string ResetPassword = "~/Views/Account/ResetPassword.cshtml";
            public string ResetPasswordConfirmation = "~/Views/Account/ResetPasswordConfirmation.cshtml";
            public string SendCode = "~/Views/Account/SendCode.cshtml";
            public string VerifyCode = "~/Views/Account/VerifyCode.cshtml";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_AccountController : R4MvcHostApp.Controllers.AccountController
    {
        public R4MVC_AccountController(): base (Dummy.Instance)
        {
        }

        [NonAction]
        partial void LoginOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string returnUrl);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Login(string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Login);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            LoginOverride(callInfo, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void LoginOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.LoginViewModel model, string returnUrl);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Login(R4MvcHostApp.Models.AccountViewModels.LoginViewModel model, string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Login);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            LoginOverride(callInfo, model, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void RegisterOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string returnUrl);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult Register(string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Register);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            RegisterOverride(callInfo, returnUrl);
            return callInfo;
        }

        [NonAction]
        partial void RegisterOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.RegisterViewModel model, string returnUrl);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Register(R4MvcHostApp.Models.AccountViewModels.RegisterViewModel model, string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Register);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            RegisterOverride(callInfo, model, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void LogoutOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Logout()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Logout);
            LogoutOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void ExternalLoginOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string provider, string returnUrl);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLogin);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "provider", provider);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ExternalLoginOverride(callInfo, provider, returnUrl);
            return callInfo;
        }

        [NonAction]
        partial void ExternalLoginCallbackOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string returnUrl, string remoteError);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ExternalLoginCallback(string returnUrl, string remoteError)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLoginCallback);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "remoteError", remoteError);
            ExternalLoginCallbackOverride(callInfo, returnUrl, remoteError);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void ExternalLoginConfirmationOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.ExternalLoginConfirmationViewModel model, string returnUrl);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ExternalLoginConfirmation(R4MvcHostApp.Models.AccountViewModels.ExternalLoginConfirmationViewModel model, string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLoginConfirmation);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ExternalLoginConfirmationOverride(callInfo, model, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void ConfirmEmailOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string userId, string code);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ConfirmEmail(string userId, string code)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ConfirmEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "code", code);
            ConfirmEmailOverride(callInfo, userId, code);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void ForgotPasswordOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ForgotPassword()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ForgotPassword);
            ForgotPasswordOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ForgotPasswordOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.ForgotPasswordViewModel model);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ForgotPassword(R4MvcHostApp.Models.AccountViewModels.ForgotPasswordViewModel model)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ForgotPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ForgotPasswordOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void ForgotPasswordConfirmationOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ForgotPasswordConfirmation()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ForgotPasswordConfirmation);
            ForgotPasswordConfirmationOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ResetPasswordOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string code);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ResetPassword(string code)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "code", code);
            ResetPasswordOverride(callInfo, code);
            return callInfo;
        }

        [NonAction]
        partial void ResetPasswordOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.ResetPasswordViewModel model);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ResetPassword(R4MvcHostApp.Models.AccountViewModels.ResetPasswordViewModel model)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ResetPasswordOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void ResetPasswordConfirmationOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ResetPasswordConfirmation()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ResetPasswordConfirmation);
            ResetPasswordConfirmationOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SendCodeOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string returnUrl, bool rememberMe);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult> SendCode(string returnUrl, bool rememberMe)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.SendCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "rememberMe", rememberMe);
            SendCodeOverride(callInfo, returnUrl, rememberMe);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.ActionResult);
        }

        [NonAction]
        partial void SendCodeOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.SendCodeViewModel model);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> SendCode(R4MvcHostApp.Models.AccountViewModels.SendCodeViewModel model)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.SendCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SendCodeOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void VerifyCodeOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string provider, bool rememberMe, string returnUrl);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> VerifyCode(string provider, bool rememberMe, string returnUrl)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.VerifyCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "provider", provider);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "rememberMe", rememberMe);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            VerifyCodeOverride(callInfo, provider, rememberMe, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void VerifyCodeOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, R4MvcHostApp.Models.AccountViewModels.VerifyCodeViewModel model);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> VerifyCode(R4MvcHostApp.Models.AccountViewModels.VerifyCodeViewModel model)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.VerifyCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            VerifyCodeOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as Microsoft.AspNetCore.Mvc.IActionResult);
        }

        [NonAction]
        partial void AccessDeniedOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult AccessDenied()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.AccessDenied);
            AccessDeniedOverride(callInfo);
            return callInfo;
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108

