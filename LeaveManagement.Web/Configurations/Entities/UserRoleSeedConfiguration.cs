using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                    UserId = "d64ea6b3-31c7-421b-ac84-585ae15f650d"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cbed41be-31de-4b31-af30-ace5f9cd9610",
                    UserId = "9ded52be-3217-4c34-af30-eca5f9cc9530"
                }
            );
        }
    }
}