﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpecLight.Output
{
    using System;
    
    #line 9 "..\..\Output\SinglePageRazorTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Output\SinglePageRazorTemplate.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 11 "..\..\Output\SinglePageRazorTemplate.cshtml"
    using SpecLight;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Output\SinglePageRazorTemplate.cshtml"
    using SpecLight.Output.ViewModel;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class SinglePageRazorTemplate : SpecLight.Output.RazorTemplateBase
    {
#line hidden
#line hidden
public System.Web.WebPages.HelperResult TagBox(IEnumerable<string> tags)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 130 "..\..\Output\SinglePageRazorTemplate.cshtml"
 
	if (tags == null || !tags.Any())
	{
		return;
	}

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t<span class=\"tags\">");



#line 135 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, string.Join(", ", tags.Select(x => "@" + x)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 136 "..\..\Output\SinglePageRazorTemplate.cshtml"

#line default
#line hidden

});

}

#line hidden
public System.Web.WebPages.HelperResult FolderToc(FolderViewModel folder)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 139 "..\..\Output\SinglePageRazorTemplate.cshtml"
 
	if (!string.IsNullOrWhiteSpace(folder.Name))
	{
		var statusCounts = folder.DescendantClasses().SelectMany(y => y.Specs.Select(x => x.Status)).ToList();

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t\t<span class=\"folderName\">\r\n\t\t\t<span class=\"folderGlyph\"></span>\r\n\t\t\t<span class" +
"=\"folderNameText\">");



#line 145 "..\..\Output\SinglePageRazorTemplate.cshtml"
 WriteTo(@__razor_helper_writer, folder.Name);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n\t\t\t<span class=\"graph\" style=\"");



#line 146 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, Gradient(statusCounts));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" title=\"");



#line 146 "..\..\Output\SinglePageRazorTemplate.cshtml"
                               WriteTo(@__razor_helper_writer, Title(statusCounts));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " in folder \'");



#line 146 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                               WriteTo(@__razor_helper_writer, folder.Name);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\"></span>\r\n\t\t</span>\r\n");



#line 148 "..\..\Output\SinglePageRazorTemplate.cshtml"
	}

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t<ul data-tags=\"");



#line 149 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, string.Join(" ", folder.DescendantClasses().SelectMany(x => x.Specs).SelectMany(x => x.EffectiveTags()).Distinct()));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">\r\n");



#line 150 "..\..\Output\SinglePageRazorTemplate.cshtml"
 		foreach (var child in folder.SubFolders.OrderBy(x => x.Name))
		{
			var featureClass = folder.DescendantClasses().SelectMany(x => x.Specs).Select(x => x.Status).DefaultIfEmpty(Status.Pending).Max().ToString().ToLowerInvariant();

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t\t\t<li class=\"folder ");



#line 153 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, featureClass);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">\r\n\r\n\t\t\t\t");



#line 155 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, FolderToc(child));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\r\n\t\t\t</li>\r\n");



#line 157 "..\..\Output\SinglePageRazorTemplate.cshtml"
		}

#line default
#line hidden



#line 158 "..\..\Output\SinglePageRazorTemplate.cshtml"
 		foreach (var feature in folder.Classes.OrderBy(x => x.Name))
		{
			var maxStatus = feature.Specs.Select(x => x.Status).DefaultIfEmpty(Status.Pending).Max();
			var featureClass = maxStatus.ToString().ToLowerInvariant();

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t\t\t<li class=\"feature ");



#line 162 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, featureClass);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" title=\"Feature: ");



#line 162 "..\..\Output\SinglePageRazorTemplate.cshtml"
                      WriteTo(@__razor_helper_writer, feature.Name);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " (");



#line 162 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                     WriteTo(@__razor_helper_writer, maxStatus);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ")\" data-tags=\"");



#line 162 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                             WriteTo(@__razor_helper_writer, string.Join(" ", feature.Specs.SelectMany(x => x.EffectiveTags()).Distinct()));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">\r\n\t\t\t\t<a class=\"featureLink\" href=\"#");



#line 163 "..\..\Output\SinglePageRazorTemplate.cshtml"
   WriteTo(@__razor_helper_writer, AnchorName(feature));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 163 "..\..\Output\SinglePageRazorTemplate.cshtml"
                         WriteTo(@__razor_helper_writer, feature.Name);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</a>\r\n\t\t\t\t<ul class=\"scenarios\">\r\n");



#line 165 "..\..\Output\SinglePageRazorTemplate.cshtml"
 					foreach (var spec in feature.Specs.OrderBy(x => x.MethodName))
					{
						var scenarioClass = spec.Status.ToString().ToLowerInvariant();

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t\t\t\t\t\t<li class=\"");



#line 168 "..\..\Output\SinglePageRazorTemplate.cshtml"
WriteTo(@__razor_helper_writer, scenarioClass);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" title=\"Scenario: ");



#line 168 "..\..\Output\SinglePageRazorTemplate.cshtml"
                   WriteTo(@__razor_helper_writer, spec.MethodName);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " (");



#line 168 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                     WriteTo(@__razor_helper_writer, spec.Status);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ")\" data-tags=\"");



#line 168 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                               WriteTo(@__razor_helper_writer, string.Join(" ", spec.EffectiveTags()));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">\r\n\t\t\t\t\t\t\t<a class=\"scenarioLink\" href=\"#");



#line 169 "..\..\Output\SinglePageRazorTemplate.cshtml"
       WriteTo(@__razor_helper_writer, AnchorName(feature, spec));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 169 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                   WriteTo(@__razor_helper_writer, spec.MethodName);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</a>\r\n\t\t\t\t\t\t</li>\r\n");



#line 171 "..\..\Output\SinglePageRazorTemplate.cshtml"
					}

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t\t\t\t</ul>\r\n\t\t\t</li>\r\n");



#line 174 "..\..\Output\SinglePageRazorTemplate.cshtml"
		}

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\t</ul>\r\n");



#line 176 "..\..\Output\SinglePageRazorTemplate.cshtml"

#line default
#line hidden

});

}


        #line 179 "..\..\Output\SinglePageRazorTemplate.cshtml"


	string AnchorName(TestClassViewModel @class, SpecViewModel spec)
	{
		return "Scenario" + @class.Name.Replace(" ", "_") + spec.MethodName.Replace(" ", "_");
	}

	string AnchorName(TestClassViewModel @class)
	{
		return "Feature" + @class.Name.Replace(" ", "_");
	}


	static readonly Dictionary<Status, string> StatusColours = new Dictionary<Status, string>
	{
		{Status.Passed, "rgba(86, 158, 78, 0.9)"},
		{Status.Failed, "rgba(238, 66, 68, 0.9)"},
		{Status.Skipped, "rgba(245, 184, 81, 0.9)"},
		{Status.Pending, "rgba(245, 220, 95, 0.9)"},
		{Status.NotRun, "transparent"},
	};

	static readonly Status[] HumanOrderedStatuses = {Status.Failed, Status.Passed, Status.Skipped, Status.Pending, Status.NotRun};

	static string Gradient(IEnumerable<Status> statuses)
	{
		double tp = 0;
		var s = "";
		foreach (var status in HumanOrderedStatuses)
		{
			var colour = StatusColours[status];
			s += string.Format(", {0} {1}%", colour, tp);
			tp += statuses.Count(y => y == status)/(double) statuses.Count()*100;
			s += string.Format(", {0} {1}%", colour, tp);
		}


		return "background-image: linear-gradient(to right" + s + ")";
	}


	static string Title(IEnumerable<Status> statuses)
	{
		var v = from s in HumanOrderedStatuses
			let count = statuses.Count(y => y == s)
			where count > 0
			select count + " " + s;

		return string.Join(", ", v);
	}


        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("\r\n");







            
            #line 14 "..\..\Output\SinglePageRazorTemplate.cshtml"
  
	var statusCounts = TemplateModel.RootFolder.DescendantClasses().SelectMany(y => y.Specs.Select(x => x.Status));
	var tags = TemplateModel.Tags.ToList();
	double fattestTagCount = tags.Select(x => x.Statuses.Count()).DefaultIfEmpty(1).Max();


            
            #line default
            #line hidden
WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n\t<head>\r\n" +
"\t\t<meta charset=\"utf-8\" />\r\n\t\t<title>Speclight report</title>\r\n\t\t<style type=\"te" +
"xt/css\">\r\n\t\t\t");


            
            #line 25 "..\..\Output\SinglePageRazorTemplate.cshtml"
Write(IncludeEmbeddedResource("Style.min.css"));

            
            #line default
            #line hidden
WriteLiteral(" \r\n\t\t</style>\r\n\t\t<script type=\"text/javascript\">\r\n\t\t\t");


            
            #line 28 "..\..\Output\SinglePageRazorTemplate.cshtml"
Write(IncludeEmbeddedResource("jquery-1.10.2.min.js"));

            
            #line default
            #line hidden
WriteLiteral(@"
		</script>



		<script type=""text/javascript"">
			$(function() {
				//folder collapsing
				$(""li.folder > span.folderName"").click(function() {
					$(this).parent().toggleClass(""collapsed"");
				});

				//highlight current item
				function updateHighlight() {
					$(""#TableOfContents a"").removeClass(""current"");
					$(""h2[id], h3[id]"").filter("":visible"").filter(function() {
						var elemTop = $(this).offset().top;
						return elemTop >= 0;
					}).first().each(function() {
						$(""#TableOfContents a[href='#"" + this.id + ""']"").addClass(""current"");
					});
				}

				$(""#Content"").scroll(updateHighlight);
				updateHighlight();

				//tag behaviour
				$(""input[data-tag-controller]"").change(function() {
					var selectedTags = $(""input[data-tag-controller]:checked"").map(function(i, d) { return $(d).data(""tag-controller""); });
					if (selectedTags.size()) {
						$(""*[data-tags]"").hide();
						selectedTags.each(function() { $(""*[data-tags~='"" + this + ""']"").show(); });
					} else {
						$(""*[data-tags]"").show();
					}
					updateHighlight();
				});
			});
		</script>
	</head>
	<body>
		<div id=""TableOfContents"">
			<div class=""graph"" style=""");


            
            #line 70 "..\..\Output\SinglePageRazorTemplate.cshtml"
                        Write(Gradient(statusCounts));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Status breakdown for all scenarios\">");


            
            #line 70 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                                            Write(Title(statusCounts));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t<div class=\"tagCloud\">\r\n");


            
            #line 72 "..\..\Output\SinglePageRazorTemplate.cshtml"
 				foreach (var tag in tags)
				{
					var fatness = (tag.Statuses.Count() - 1)/fattestTagCount;
					var size = 90 + fatness*60;


            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<input id=\"tagCheckbox-");


            
            #line 77 "..\..\Output\SinglePageRazorTemplate.cshtml"
                       Write(tag.Name);

            
            #line default
            #line hidden
WriteLiteral("\" type=\"checkbox\" data-tag-controller=\"");


            
            #line 77 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                       Write(tag.Name);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");



WriteLiteral("\t\t\t\t\t<label for=\"tagCheckbox-");


            
            #line 78 "..\..\Output\SinglePageRazorTemplate.cshtml"
                        Write(tag.Name);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Tag \'");


            
            #line 78 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                               Write(tag.Name);

            
            #line default
            #line hidden
WriteLiteral("\' (");


            
            #line 78 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                           Write(Title(tag.Statuses));

            
            #line default
            #line hidden
WriteLiteral(") - Click to filter\" style=\"");


            
            #line 78 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                                                           Write(Gradient(tag.Statuses));

            
            #line default
            #line hidden
WriteLiteral("; font-size: ");


            
            #line 78 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                                                                                                Write(size);

            
            #line default
            #line hidden
WriteLiteral("%\">");


WriteLiteral("@");


            
            #line 78 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                                                                                                           Write(tag.Name);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");


            
            #line 79 "..\..\Output\SinglePageRazorTemplate.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t</div>\r\n\t\t\t");


            
            #line 81 "..\..\Output\SinglePageRazorTemplate.cshtml"
Write(FolderToc(TemplateModel.RootFolder));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t\t</div>\r\n\t\t<div id=\"Content\">\r\n\t\t\t<h1>Speclight report</h1>\r\n\r\n");


            
            #line 87 "..\..\Output\SinglePageRazorTemplate.cshtml"
 			foreach (var testClass in TemplateModel.RootFolder.DescendantClasses())
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div class=\"feature\" data-tags=\"");


            
            #line 89 "..\..\Output\SinglePageRazorTemplate.cshtml"
                               Write(string.Join(" ", testClass.Specs.SelectMany(x => x.EffectiveTags()).Distinct()));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t\t<h2 id=\"");


            
            #line 90 "..\..\Output\SinglePageRazorTemplate.cshtml"
        Write(AnchorName(testClass));

            
            #line default
            #line hidden
WriteLiteral("\">Class: ");


            
            #line 90 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                       Write(testClass.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\t\t\t\t\t");


            
            #line 91 "..\..\Output\SinglePageRazorTemplate.cshtml"
Write(TagBox(testClass.Specs.SelectMany(x => x.EffectiveTags()).Distinct()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 92 "..\..\Output\SinglePageRazorTemplate.cshtml"
 					foreach (var spec in testClass.Specs.OrderBy(x => x.MethodName))
					{
						var firstError = spec.Spec.Outcomes.Select(x => x.Error).FirstOrDefault(x => x != null);

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t<div class=\"scenario ");


            
            #line 95 "..\..\Output\SinglePageRazorTemplate.cshtml"
                      Write(spec.Status.ToString().ToLowerInvariant());

            
            #line default
            #line hidden
WriteLiteral("\" data-tags=\"");


            
            #line 95 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                             Write(string.Join(" ", spec.EffectiveTags()));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t\t\t\t<h3 id=\"");


            
            #line 96 "..\..\Output\SinglePageRazorTemplate.cshtml"
          Write(AnchorName(testClass, spec));

            
            #line default
            #line hidden
WriteLiteral("\">Method: ");


            
            #line 96 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                Write(spec.MethodName);

            
            #line default
            #line hidden
WriteLiteral("  (");


            
            #line 96 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                   Write(spec.Status.ToString());

            
            #line default
            #line hidden
WriteLiteral(")</h3>\r\n\t\t\t\t\t\t\t");


            
            #line 97 "..\..\Output\SinglePageRazorTemplate.cshtml"
  Write(TagBox(spec.Spec.SpecTags));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t<p class=\"description\">");


            
            #line 98 "..\..\Output\SinglePageRazorTemplate.cshtml"
                         Write(spec.Spec.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<ul>\r\n");


            
            #line 100 "..\..\Output\SinglePageRazorTemplate.cshtml"
 								foreach (var o in spec.Spec.Outcomes)
								{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t\t<li class=\"");


            
            #line 102 "..\..\Output\SinglePageRazorTemplate.cshtml"
               Write(o.Status.ToString().ToLowerInvariant());

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 102 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                        Write(o.Empty?"empty":"");

            
            #line default
            #line hidden
WriteLiteral("\" title=\"");


            
            #line 102 "..\..\Output\SinglePageRazorTemplate.cshtml"
                                                                                     Write(o.Error);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t\t<em>");


            
            #line 103 "..\..\Output\SinglePageRazorTemplate.cshtml"
         Write(o.Step.Type);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n\t\t\t\t\t\t\t\t\t\t");


            
            #line 104 "..\..\Output\SinglePageRazorTemplate.cshtml"
     Write(o.Step.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<strong>\r\n\t\t\t\t\t\t\t\t\t\t\t");


            
            #line 106 "..\..\Output\SinglePageRazorTemplate.cshtml"
      Write(o.Status);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 107 "..\..\Output\SinglePageRazorTemplate.cshtml"
 											if (o.Empty)
											{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<span title=\"Test step contained no code\">(Empty)</span>\r\n");


            
            #line 110 "..\..\Output\SinglePageRazorTemplate.cshtml"
											}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t\t\t</strong>\r\n\t\t\t\t\t\t\t\t\t\t");


            
            #line 112 "..\..\Output\SinglePageRazorTemplate.cshtml"
     Write(TagBox(o.Step.Tags));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</li>\r\n");


            
            #line 114 "..\..\Output\SinglePageRazorTemplate.cshtml"
								}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t</ul>\r\n");


            
            #line 116 "..\..\Output\SinglePageRazorTemplate.cshtml"
 							if (firstError != null)
							{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"errorMessage\">");


            
            #line 118 "..\..\Output\SinglePageRazorTemplate.cshtml"
                             Write(firstError);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");


            
            #line 119 "..\..\Output\SinglePageRazorTemplate.cshtml"
							}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t</div>\r\n");


            
            #line 121 "..\..\Output\SinglePageRazorTemplate.cshtml"
					}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t</div>\r\n");


            
            #line 123 "..\..\Output\SinglePageRazorTemplate.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n\r\n\t</body>\r\n</html>\r\n\r\n");



WriteLiteral("\r\n\r\n");



WriteLiteral("\r\n\r\n");



        }
    }
}
#pragma warning restore 1591
