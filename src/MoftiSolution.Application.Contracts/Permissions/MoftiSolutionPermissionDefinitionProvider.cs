using MoftiSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace MoftiSolution.Permissions;

public class MoftiSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MoftiSolutionPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(MoftiSolutionPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(MoftiSolutionPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(MoftiSolutionPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(MoftiSolutionPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MoftiSolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MoftiSolutionResource>(name);
    }
}
