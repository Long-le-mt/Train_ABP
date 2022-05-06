using System.Threading.Tasks;
using Acme.BookStore.Localization;
using Acme.BookStore.MultiTenancy;
using Acme.BookStore.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.BookStore.Web.Menus
{
    public class BookStoreMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var administration = context.Menu.GetAdministration();
            var l = context.GetLocalizer<BookStoreResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    BookStoreMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                )
            );
            context.Menu.AddItem(new ApplicationMenuItem("TongQuan", "Tổng quan", icon: "fa fa-circle", order: 1, url: "/#"));

            var boPhan = await context.IsGrantedAsync(BookStorePermissions.BoPhan.Default);
            if (boPhan)
            {
                context.Menu.AddItem(new ApplicationMenuItem("BoPhan", "Bộ phận", icon: "fa fa-circle", order: 2, url: "/Commons/BoPhan"));
            }


            var nhanVien = await context.IsGrantedAsync(BookStorePermissions.NhanVien.Default);
            if (boPhan)
            {
                context.Menu.AddItem(new ApplicationMenuItem("NhanVien", "Nhân viên", icon: "fa fa-users", order: 3, url: "/Commons/NhanVien"));
            }

            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
        }
    }
}
