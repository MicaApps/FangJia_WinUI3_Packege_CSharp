﻿//------------------------------------------------------------------------
// 本应用部分代码参考了以下开源项目：
// 1.WinUi3 Gallery
// 2.WinUI Community Toolkit
// 3.部分代码由 ChatGPT 、DeepSeek、Copilot 生成
// 版权归原作者所有
// FangJia 仅做学习交流使用
// 转载请注明出处
//------------------------------------------------------------------------

using FangJia.Common;
using FangJia.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FangJia.Helpers;

public static class NavigationHelper
{
    public static readonly Dictionary<string, CategoryBase> Categorizes = new()
    {
        { "Home", new Category { Name = "首页", Glyph = "\uE80F", Path = "HomePage", Tooltip = "首页" } },
        { "Data", new Category { Name = "数据", Glyph = "\uE8F1", Path = "DataPage", Tooltip = "数据：维护数据库内容，包括方剂、药物、经典、医案等。", } },
        { "About", new Category { Name = "关于", Glyph = "\uE946", Path = "AboutPage", Tooltip = "关于：软件版权及版本信息。" } },
        // 数据子项
        { "Formulation", new Category { Name = "方剂", Glyph = "\uE8A1", Path = "FormulationPage", Tooltip = "方剂：维护方剂信息。" } },
        { "Drug", new Category { Name = "药物", Glyph = "\uE89A", Path = "DrugPage", Tooltip = "药物：维护药物信息。" } },
        { "Classic", new Category { Name = "经典", Glyph = "\uE82D", Path = "ClassicPage", Tooltip = "经典：维护经典信息。" } },
        { "Case", new Category { Name = "医案", Glyph = "\uE95E", Path = "CasePage", Tooltip = "医案：维护医案信息。" } },
        // 设置
        { "Settings", new Category { Glyph = "\uE713", Name = "设置", Path = "SettingsPage", Tooltip = "设置" } },
        { "Logs", new Category(){Glyph = "\uF000",Name = "日志",Path = "LogsPage",Tooltip = "日志详情"}},
        // 分隔符
        { "Separator", new Separator() }
    };

    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
    public static Type GetType(string? path)
    {
        return path switch
        {
            "HomePage" => typeof(HomePage),
            "DataPage" => typeof(DataPage),
            "AboutPage" => typeof(AboutPage),
            "FormulationPage" => typeof(FormulationPage),
            "DrugPage" => typeof(DrugPage),
            "ClassicPage" => typeof(ClassicPage),
            "CasePage" => typeof(CasePage),
            "SettingsPage" => typeof(SettingsPage),
            "LogsPage" => typeof(LogsPage),
            _ => throw new NotImplementedException()
        };
    }
}