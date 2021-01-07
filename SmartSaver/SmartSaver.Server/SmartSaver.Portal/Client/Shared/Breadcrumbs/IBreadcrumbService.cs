using System;
using System.Collections.Generic;
using SmartSaver.Portal.Client.Models;

namespace SmartSaver.Portal.Client.Shared.Breadcrumbs
{
    public interface IBreadcrumbService
    {
        event Action BreadcrumbsChanged;

        void InvokeBreadcrumbsChanged();

        public void AddBreadcrumb(string breadcrumbDisplayName, string url);

        public void ClearList();

        IReadOnlyList<Breadcrumb> GetBreadcrumbsList();
    }
}