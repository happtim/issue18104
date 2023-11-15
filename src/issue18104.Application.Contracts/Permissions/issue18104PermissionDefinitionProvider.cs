using issue18104.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace issue18104.Permissions;

public class issue18104PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(issue18104Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(issue18104Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<issue18104Resource>(name);
    }
}
