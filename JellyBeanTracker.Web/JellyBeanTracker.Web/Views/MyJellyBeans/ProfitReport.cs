#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace JellyBeanTracker.Mobile
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class ProfitReport : System.Web.Mvc.WebViewPage<JellyBeanTracker.Shared.DisplayModels.ProfitReportModel>
{

#line hidden

public override void Execute()
{

#line 3 "ProfitReport.cshtml"
  
    ViewBag.Title = "ProfitReport";


#line default
#line hidden
WriteLiteral("\r\n\r\n");


#line 7 "ProfitReport.cshtml"
 if (JellyBeanTracker.Web.Globals.Native) {
    

#line default
#line hidden

#line 8 "ProfitReport.cshtml"
Write(Html.Partial("JellyBeanTracker.Mobile.External.Web.Views.Shared.Header, JellyBeanTracker.Mobile", null));


#line default
#line hidden

#line 8 "ProfitReport.cshtml"
                                                                                                            ;
}


#line default
#line hidden
WriteLiteral("\r\n<h2>Profit Report</h2>\r\n\r\n<h3>Welcome to your beautiful profit report.</h3>\r\n\r\n" +
"\r\n<h4>You invested a total of <strong>$");


#line 16 "ProfitReport.cshtml"
                                Write(Model.TotalInvested);


#line default
#line hidden
WriteLiteral("</strong> and after losses of <strong>$");


#line 16 "ProfitReport.cshtml"
                                                                                           Write(Model.Loses);


#line default
#line hidden
WriteLiteral("</strong> and gains \r\n    of <strong>$");


#line 17 "ProfitReport.cshtml"
           Write(Model.Gains);


#line default
#line hidden
WriteLiteral("</strong> your total jellybean worth is <strong>$");


#line 17 "ProfitReport.cshtml"
                                                                        Write(Model.TotalOutcome);


#line default
#line hidden
WriteLiteral("</strong>.\r\n</h4>\r\n");


#line 19 "ProfitReport.cshtml"
  
    var maxTotals = Math.Max(Model.TotalInvested, Model.TotalOutcome);
    var maxGains = Math.Max(Model.Loses, Model.Gains);

    var percentIn = ((int)(Model.TotalInvested / maxTotals * 100));
    var percentOu = ((int)(Model.TotalOutcome / maxTotals * 100));
    
    var percentLo = ((int)(Model.Loses / maxGains * 100));
    var percentGa = ((int)(Model.Gains / maxGains * 100));    


#line default
#line hidden
WriteLiteral("\r\n<h2>Totals</h2>\r\n<h5>Invested <strong>$");


#line 30 "ProfitReport.cshtml"
                 Write(Model.TotalInvested);


#line default
#line hidden
WriteLiteral("</strong></h5>\r\n<div");

WriteLiteral(" class=\"barContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"overallBar\"");

WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "width:", true)

#line 32 "ProfitReport.cshtml"
  , Tuple.Create<string,object,bool> (" ", percentIn

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "%;", true)
);
WriteLiteral("></div>\r\n</div>\r\n\r\n<h5>Outcome <strong>$");


#line 35 "ProfitReport.cshtml"
                Write(Model.TotalOutcome);


#line default
#line hidden
WriteLiteral("</strong></h5>\r\n<div");

WriteLiteral(" class=\"barContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"overallBar green\"");

WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "width:", true)

#line 37 "ProfitReport.cshtml"
        , Tuple.Create<string,object,bool> (" ", percentOu

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "%;", true)
);
WriteLiteral("></div>\r\n</div>\r\n\r\n<h2>Performance</h2>\r\n<h5>Gains <strong>$");


#line 41 "ProfitReport.cshtml"
              Write(Model.Gains);


#line default
#line hidden
WriteLiteral("</strong></h5>\r\n<div");

WriteLiteral(" class=\"barContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"overallBar green\"");

WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "width:", true)

#line 43 "ProfitReport.cshtml"
        , Tuple.Create<string,object,bool> (" ", percentGa

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "%;", true)
);
WriteLiteral("></div>\r\n</div>\r\n\r\n<h5>Losses <strong>$");


#line 46 "ProfitReport.cshtml"
               Write(Model.Loses);


#line default
#line hidden
WriteLiteral("</strong></h5>\r\n<div");

WriteLiteral(" class=\"barContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"overallBar red\"");

WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "width:", true)

#line 48 "ProfitReport.cshtml"
      , Tuple.Create<string,object,bool> (" ", percentLo

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "%;", true)
);
WriteLiteral("></div>\r\n</div>\r\n\r\n\r\n");


#line 52 "ProfitReport.cshtml"
 if (JellyBeanTracker.Web.Globals.Native) {
    

#line default
#line hidden

#line 53 "ProfitReport.cshtml"
Write(Html.Partial("JellyBeanTracker.Mobile.External.Web.Views.Shared.Footer, JellyBeanTracker.Mobile", null));


#line default
#line hidden

#line 53 "ProfitReport.cshtml"
                                                                                                            ;
}


#line default
#line hidden
WriteLiteral("\r\n");

}
}
}
#pragma warning restore 1591
