using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStorePermissions.GroupName);
            var myGroupCommon = context.AddGroup(BookStorePermissions.GroupNameCommon, L("Permission:Common"));

            var boPhanPermission = myGroupCommon.AddPermission(BookStorePermissions.BoPhan.Default, L("Permission:BoPhan"));
            boPhanPermission.AddChild(BookStorePermissions.BoPhan.Create, L("Permission:Create"));
            boPhanPermission.AddChild(BookStorePermissions.BoPhan.Update, L("Permission:Update"));
            boPhanPermission.AddChild(BookStorePermissions.BoPhan.Delete, L("Permission:Delete"));

            var nhanVienPermission = myGroupCommon.AddPermission(BookStorePermissions.NhanVien.Default, L("Permission:NhanVien"));
            nhanVienPermission.AddChild(BookStorePermissions.NhanVien.Create, L("Permission:Create"));
            nhanVienPermission.AddChild(BookStorePermissions.NhanVien.Update, L("Permission:Update"));
            nhanVienPermission.AddChild(BookStorePermissions.NhanVien.Delete, L("Permission:Delete"));
        
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }
}
